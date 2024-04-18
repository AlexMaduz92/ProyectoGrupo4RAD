using Datos.Base_de_Dato;
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
using Negocio;
using Datos.Core;

namespace Presentacion
{
    public partial class PUMediDas : Form
    {
        private readonly UnitOfWork unitOfWork;
        public PUMediDas()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            BtnCerrar.Click += BtnCerrar_Click;
            BtnGuarda.Click += BtnGuarda_Click;
            BtnModifica.Click+= BtnModifica_Click;
            BtnElimina.Click += BtnElimina_Click;

        }

        private void PUMediDas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet19.UnidadMedidas' Puede moverla o quitarla según sea necesario.
            this.unidadMedidasTableAdapter1.Fill(this.proyectoRadDataSet19.UnidadMedidas);


            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TXTIDS.Text = proximoId.ToString();
            CargarDatosEstadoActivo();
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();

            DGVMEDIDA.CellDoubleClick += DGVMEDIDA_CellDoubleClick;
        }

        private void DGVMEDIDA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewTextBoxColumn estadoColumn = new DataGridViewTextBoxColumn();
                estadoColumn.Name = "EstadoDataGridViewTextBoxColumn";
                estadoColumn.HeaderText = "Estado";
                estadoColumn.DataPropertyName = "Estado";
                estadoColumn.Visible = false;
                DGVMEDIDA.Columns.Add(estadoColumn);
                DataGridViewRow selectedRow = DGVMEDIDA.Rows[e.RowIndex];

                TXTIDS.Text = selectedRow.Cells["UnidadMedidaIdDataGridViewTextBoxColumn"].Value.ToString();
                Txtcodig.Text = selectedRow.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();
                TxtDescrip.Text = selectedRow.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();

                // Check if the cell value is "True" for the Estado column
                string estadoValue = selectedRow.Cells["EstadoDataGridViewTextBoxColumn"].Value.ToString();
                if (estadoValue.Equals("True", StringComparison.OrdinalIgnoreCase))
                {
                    CBEstados.Checked = true;
                }
                else
                {
                    CBEstados.Checked = false;
                }

                DTFcreaciones.Value = DateTime.Parse(selectedRow.Cells["FechaCreacionDataGridViewTextBoxColumn"].Value.ToString());
            }
        }

        private void ActualizarDataGrid()
        {
            this.unidadMedidasTableAdapter1.Fill(this.proyectoRadDataSet19.UnidadMedidas);
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

         private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.proyectoRadDataSet19.UnidadMedidas);
            view.RowFilter = "Estado = true";
            DGVMEDIDA.DataSource = view;

        }
        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.proyectoRadDataSet19.UnidadMedidas);
            view.RowFilter = "Estado = false";
            DGVMEDIDA.DataSource = view;
        }

        private void CBXFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el filtro seleccionado
            string filtro = CBXFiltro.SelectedItem.ToString();

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

        private void limpiar()
        {
            TXTIDS.Text = "";
            Txtcodig.Text = "";
            TxtDescrip.Text = "";
            CBEstados.Checked = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuarda_Click(object sender, EventArgs e)
        {
            string codigo = Txtcodig.Text;
            string descripcion = TxtDescrip.Text;
            bool estado = CBEstados.Checked;
            DateTime fechaCreacion = DTFcreaciones.Value;

            DialogResult result = MessageBox.Show("¿Desea guardar la medida?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UnidadMedida medida = new UnidadMedida
                {
                    Codigo = codigo,
                    Descripcion = descripcion,
                    Estado = estado,
                    FechaCreacion = fechaCreacion
                };

                try
                {
                    NUMedidas negocioMedidas = new NUMedidas();
                    negocioMedidas.GuardarMedida(medida);
                    MessageBox.Show("Medida guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la medida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiar();
            ActualizarDataGrid();
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            int id = int.Parse(TXTIDS.Text);
            string codigo = Txtcodig.Text;
            string descripcion = TxtDescrip.Text;
            bool estado = CBEstados.Checked;
            DateTime fechaCreacion = DTFcreaciones.Value;
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

                    ActualizarDataGrid();
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
            BtnModifica.Enabled = false;
            BtnGuarda.Enabled = false;

            // Obtener el ID del cliente a eliminar
            int id = int.Parse(TXTIDS.Text);

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

                    ActualizarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ActualizarDataGrid();
            BtnModifica.Enabled = true;
            BtnGuarda.Enabled = true;
            limpiar();
        }



    }
}
