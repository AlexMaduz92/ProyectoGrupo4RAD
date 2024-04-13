using Datos;
using Datos.Base_de_Dato;
using Datos.Core;
using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PCategoria : Form
    {
        private readonly UnitOfWork unitOfWork;

        Dcategorial dcategorial;
        public PCategoria()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
        }

        private void PCategoria_Load(object sender, EventArgs e)
        {
            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();

            // Cargar datos en el DataGridView
            this.categoriasTableAdapter.Fill(this.proyectoRadDataSet.Categorias);

            // Asignar el evento CellDoubleClick al DataGridView
            DGVCategoria.CellDoubleClick += DGVCategoria_CellContentDoubleClick;

            // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
            DataView dv = new DataView(this.proyectoRadDataSet.Categorias);
            dv.RowFilter = "Estado = true";

            // Asignar el DataView filtrado al DataGridView
            DGVCategoria.DataSource = dv;

        }
        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<Cliente>().Max(g => g.ClienteId);
            }
            return maxId + 1;
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
            // Obtener el ID del cliente a eliminar
            int id = int.Parse(TxtID.Text);

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea eliminar la Categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Actualizar el Estado del descuento a 0
                    Categoria categoria = unitOfWork.Repository<Categoria>().ObtenerPorId(id);
                    categoria.Estado = false; // 0 representa falso

                    // Guardar los cambios en la base de datos
                    unitOfWork.Repository<Categoria>().Editar(categoria);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.categoriasTableAdapter.Fill(this.proyectoRadDataSet.Categorias);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            limpiar();

        }

        void limpiar()
        {
            TxtID.Text = "";
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            CBEstado.Checked = false;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            int id = int.Parse(TxtID.Text);
            string codigo = TxtCodigo.Text;
            string descripcion = TxtDescripcion.Text;
            bool estado = CBEstado.Checked;

            DateTime fechaCreacion = DTFCreacion.Value;
            try
            {
                // Obtener el GrupoDescuento existente desde el contexto
                Categoria categoria = unitOfWork.Repository<Categoria>().ObtenerPorId(id);

                // Modificar las propiedades del objeto existente
                categoria.Codigo = codigo;
                categoria.Descripcion=descripcion;
                categoria.Estado = estado;
                categoria.FechaCreacion = fechaCreacion;

                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Desea modificar la Categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Guardar los cambios en la base de datos
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.categoriasTableAdapter.Fill(this.proyectoRadDataSet.Categorias);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string codigo = TxtCodigo.Text;
            string descripcion = TxtDescripcion.Text;
            bool estado = CBEstado.Checked;
            DateTime fechaCreacion = DTFCreacion.Value;

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea guardar la categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Categoria categoria = new Categoria
                {
                    Codigo = codigo,
                    Descripcion =descripcion,
                    Estado = estado,
                    FechaCreacion = fechaCreacion
                };

                try
                {
                    // Guardar el objeto en la base de datos
                    unitOfWork.Repository<Categoria>().Agregar(categoria);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.categoriasTableAdapter.Fill(this.proyectoRadDataSet.Categorias);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la Categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            limpiar();
        }
        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.categoriasTableAdapter.Fill(this.proyectoRadDataSet.Categorias);
        }

        private void DGVCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVCategoria.Rows[e.RowIndex];
                TxtID.Text = row.Cells["CategoriaIdDataGridViewTextBoxColumn"].Value.ToString();
                TxtCodigo.Text = row.Cells["CodigoDataGridViewTextBoxColumn"].Value.ToString();
                TxtDescripcion.Text = row.Cells["DescripcionDataGridViewTextBoxColumn"].Value.ToString();
                CBEstado.Checked = Convert.ToBoolean(row.Cells["EstadoDataGridViewCheckBoxColumn"].Value);
                DTFCreacion.Value = Convert.ToDateTime(row.Cells["FechaCreacionDataGridViewTextBoxColumn"].Value);
              
            }
        }
    }
}
