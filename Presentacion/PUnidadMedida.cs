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

namespace Negocio
{
    public partial class PUnidadMedida : Form
    {
        private readonly UnitOfWork unitOfWork;
        public PUnidadMedida()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            BtnGuarda.Click += BtnGuarda_Click;
            BtnModifica.Click += BtnModifica_Click;
            BtnElimina.Click += BtnElimina_Click;
        }


        private void PUnidadMedida_Load(object sender, EventArgs e)
        {
            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();

            // Cargar datos en el DataGridView
            this.unidadMedidasTableAdapter.Fill(this.proyectoRadDataSet3.UnidadMedidas);

            // Asignar el evento CellDoubleClick al DataGridView
            DGVMedida.CellDoubleClick += DGVUMedidas_CellContentDoubleClick;

            // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
            DataView dv = new DataView(this.proyectoRadDataSet3.UnidadMedidas);
            dv.RowFilter = "Estado = true";

            // Asignar el DataView filtrado al DataGridView
            DGVMedida.DataSource = dv;

        }
        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<UnidadMedida>().Max(g => g.UnidadMedidaId);
            }
            return maxId + 1;
        }
        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.unidadMedidasTableAdapter.Fill(this.proyectoRadDataSet3.UnidadMedidas);
        }

        private void BtnGuarda_Click(object sender, EventArgs e)
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
                UnidadMedida unidad = new UnidadMedida
                {
                    Codigo = codigo,
                    Descripcion = descripcion,
                    Estado = estado,
                    FechaCreacion = fechaCreacion
                };

                try
                {
                    // Guardar el objeto en la base de datos
                    unitOfWork.Repository<UnidadMedida>().Agregar(unidad);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.unidadMedidasTableAdapter.Fill(this.proyectoRadDataSet3.UnidadMedidas);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la Categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            limpiar();
        }

        private void BtnModifica_Click(object sender, EventArgs e)
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
                UnidadMedida unidad = unitOfWork.Repository<UnidadMedida>().ObtenerPorId(id);

                // Modificar las propiedades del objeto existente
                unidad.Codigo = codigo;
                unidad.Descripcion = descripcion;
                unidad.Estado = estado;
                unidad.FechaCreacion = fechaCreacion;

                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Desea modificar la Categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Guardar los cambios en la base de datos
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.unidadMedidasTableAdapter.Fill(this.proyectoRadDataSet3.UnidadMedidas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }

        private void BtnElimina_Click(object sender, EventArgs e)
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
                    UnidadMedida unidad = unitOfWork.Repository<UnidadMedida>().ObtenerPorId(id);
                    unidad.Estado = false; // 0 representa falso

                    // Guardar los cambios en la base de datos
                    unitOfWork.Repository<UnidadMedida>().Editar(unidad);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.unidadMedidasTableAdapter.Fill(this.proyectoRadDataSet3.UnidadMedidas);
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

        private void DGVUMedidas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  
    }
}
