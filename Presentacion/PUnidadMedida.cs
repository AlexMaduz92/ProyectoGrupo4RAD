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
    public partial class PUnidadMedidA : Form
    {
        private readonly UnitOfWork unitOfWork;
        public PUnidadMedidA()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            BtnGuarda.Click += BtnGuarda_Click;
            BtnModifica.Click += BtnModifica_Click;
            BtnElimina.Click += BtnElimina_Click;
            BtnCerrar.Click += BtnCerrar_Click;
        }


        private void PUnidadMedida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet18.UnidadMedidas' Puede moverla o quitarla según sea necesario.
            this.unidadMedidasTableAdapter2.Fill(this.proyectoRadDataSet18.UnidadMedidas);
            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TXTIDS.Text = proximoId.ToString();

            // Asignar el DataTable directamente al BindingSource y al DataGridView
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = this.proyectoRadDataSet16.UnidadMedidas;
            DGVUMedidas.DataSource = bindingSource;
            CBXFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarDatosEstadoActivo();
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();

        }

        private void BtnGuarda_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si la tecla presionada es Enter, desvincular el evento Click y llamar a BtnGuarda_Click
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnGuarda.Click -= BtnGuarda_Click;
                BtnGuarda_Click(sender, e);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            // Obtener el BindingSource del DataGridView
            this.unidadMedidasTableAdapter2.Fill(this.proyectoRadDataSet18.UnidadMedidas);


        }


        private void BtnGuarda_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string codigo = Txtcodig.Text;
            string descripcion = TxtDescrip.Text;
            bool estado = CBEstados.Checked;
            DateTime fechaCreacion = DTFcreaciones.Value;

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

                    ActualizarDataGridView();
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

                     ActualizarDataGridView();
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

                    ActualizarDataGridView();
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
            TXTIDS.Text = "";
            Txtcodig.Text = "";
            TxtDescrip.Text = "";
            CBEstados.Checked = false;
        }


        private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.proyectoRadDataSet18.UnidadMedidas);
            view.RowFilter = "Estado = true";
            DGVUMedidas.DataSource = view;
        }

        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.proyectoRadDataSet18.UnidadMedidas);
            view.RowFilter = "Estado = false";
            DGVUMedidas.DataSource = view;
        }


        private void CBXFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el filtro seleccionado
            string filtro = CBXFiltro.SelectedItem.ToString();

            // Obtener el BindingSource del DataGridView
            this.unidadMedidasTableAdapter2.Fill(this.proyectoRadDataSet18.UnidadMedidas);

            // Actualizar el DataGridView según el filtro seleccionado
            if (filtro == "Activos")
            {
                CargarDatosEstadoActivo();
            }
            else if (filtro == "No Activos")
            {
                CargarDatosEstadoNoActivo();
            }
        }




    }
}
