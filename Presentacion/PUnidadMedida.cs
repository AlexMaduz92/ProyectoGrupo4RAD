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
            DGVUMedidas.CellDoubleClick += DGVUMedidas_CellDoubleClick;
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
            bindingSource.DataSource = this.proyectoRadDataSet18.UnidadMedidas;
            DGVUMedidas.DataSource = bindingSource;
            CBXFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarDatosEstadoActivo();
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();
        }

        private void DGVUMedidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVUMedidas.Rows[e.RowIndex];
                int id = (int)row.Cells["UnidadMedidaId"].Value;

                // Load the data for the selected row into the form fields
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    UnidadMedida unidad = unitOfWork.Repository<UnidadMedida>().ObtenerPorId(id);
                    if (unidad != null)
                    {
                        TxtCodi.Text = unidad.Codigo;
                        TxtDescrip.Text = unidad.Descripcion;
                        CBEstado.Checked = unidad.Estado;
                        DTFCreacion.Value = unidad.FechaCreacion;
                    }
                }
            }
        }


        private void BtnGuarda_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            BindingSource bindingSource = (BindingSource)DGVUMedidas.DataSource;
            bindingSource.ResetBindings(false);
        }

        private void BtnGuarda_Click(object sender, EventArgs e)
        {
            string codigo = TxtCodi.Text;
            string descripcion = TxtDescrip.Text;
            bool estado = CBEstados.Checked;
            DateTime fechaCreacion = DTFcreaciones.Value;

            DialogResult result = MessageBox.Show("¿Desea guardar la categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    unitOfWork.Repository<UnidadMedida>().Agregar(unidad);
                    unitOfWork.Guardar();
                    ActualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la Categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            limpiar();
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            string codigo = TxtCodigo.Text;
            string descripcion = TxtDescripcion.Text;
            bool estado = CBEstado.Checked;
            DateTime fechaCreacion = DTFCreacion.Value;

            try
            {
                UnidadMedida unidad = unitOfWork.Repository<UnidadMedida>().ObtenerPorId(id);
                unidad.Codigo = codigo;
                unidad.Descripcion = descripcion;
                unidad.Estado = estado;
                unidad.FechaCreacion = fechaCreacion;

                DialogResult result = MessageBox.Show("¿Desea modificar la Categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    unitOfWork.Guardar();
                    ActualizarDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
        }

        private void BtnElimina_Click(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
            int id = int.Parse(TxtID.Text);

            DialogResult result = MessageBox.Show("¿Desea eliminar la Categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    UnidadMedida unidad = unitOfWork.Repository<UnidadMedida>().ObtenerPorId(id);
                    unidad.Estado = false;
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
            TxtCodigo.Text = "";
            TxtDescrip.Text = "";
            CBEstados.Checked = false;
        }

        private void CargarDatosEstadoActivo()
        {
            DataView view = new DataView(this.proyectoRadDataSet18.UnidadMedidas);
            view.RowFilter = "Estado = true";
            DGVUMedidas.DataSource = view;
        }

        private void CargarDatosEstadoNoActivo()
        {
            DataView view = new DataView(this.proyectoRadDataSet18.UnidadMedidas);
            view.RowFilter = "Estado = false";
            DGVUMedidas.DataSource = view;
        }

        private void CBXFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = CBXFiltro.SelectedItem.ToString();
            BindingSource bindingSource = (BindingSource)DGVUMedidas.DataSource;
            bindingSource.RemoveFilter();

            if (filtro == "Activos")
            {
                bindingSource.Filter = "Estado = true";
            }
            else if (filtro == "No Activos")
            {
                bindingSource.Filter = "Estado = false";
            }
        }
    }
}
