using Datos.Base_de_Dato;
using Datos.Core;
using Datos.Modelo;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PDescuento : Form
    {
        private readonly UnitOfWork unitOfWork;

        public PDescuento()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
        }

        private void PDescuento_Load(object sender, EventArgs e)
        {
            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();

            // Cargar datos en el DataGridView
            this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);

            // Asignar el evento CellDoubleClick al DataGridView
            DGVDescuento.CellDoubleClick += DGVDescuento_CellDoubleClick;

            // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
            DataView dv = new DataView(this.proyectoRadDataSet1.GrupoDescuentoes);
            dv.RowFilter = "Estado = true";

            // Asignar el DataView filtrado al DataGridView
            DGVDescuento.DataSource = dv;

        }

        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<GrupoDescuento>().Max(g => g.GrupoDescuentoId);
            }
            return maxId + 1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string codigo = TxtCodigo.Text;
            string descripcion = TxtDescripcion.Text;
            bool estado = CBEstado.Checked;
            decimal porcentaje;
            DateTime fechaCreacion = DTFCreacion.Value;

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea guardar el descuento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(TxtPorcentaje.Text, out porcentaje))
                {
                    MessageBox.Show("Porcentaje debe ser un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear un nuevo objeto GrupoDescuento
                GrupoDescuento grupoDescuento = new GrupoDescuento
                {
                    Codigo = codigo,
                    Descripcion = descripcion,
                    Estado = estado,
                    Porcentaje = porcentaje,
                    FechaCreacion = fechaCreacion
                };

                try
                {
                    // Guardar el objeto en la base de datos
                    unitOfWork.Repository<GrupoDescuento>().Agregar(grupoDescuento);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el descuento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            LimpiarCampos();
        }

        private void DGVDescuento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVDescuento.Rows[e.RowIndex];
                TxtID.Text = row.Cells["GrupoDescuentoIdDataGridViewTextBoxColumn"].Value.ToString();
                TxtCodigo.Text = row.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();
                TxtDescripcion.Text = row.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();
                CBEstado.Checked = Convert.ToBoolean(row.Cells["estadoDataGridViewCheckBoxColumn"].Value);
                DTFCreacion.Value = Convert.ToDateTime(row.Cells["fechaCreacionDataGridViewTextBoxColumn"].Value);
                TxtPorcentaje.Text = row.Cells["porcentajeDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            int id = int.Parse(TxtID.Text);
            string codigo = TxtCodigo.Text;
            string descripcion = TxtDescripcion.Text;
            bool estado = CBEstado.Checked;
            decimal porcentaje;
            DateTime fechaCreacion = DTFCreacion.Value;

            if (!decimal.TryParse(TxtPorcentaje.Text, out porcentaje))
            {
                MessageBox.Show("Porcentaje debe ser un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener el GrupoDescuento existente desde el contexto
                GrupoDescuento grupoDescuento = unitOfWork.Repository<GrupoDescuento>().ObtenerPorId(id);

                // Modificar las propiedades del objeto existente
                grupoDescuento.Codigo = codigo;
                grupoDescuento.Descripcion = descripcion;
                grupoDescuento.Estado = estado;
                grupoDescuento.Porcentaje = porcentaje;
                grupoDescuento.FechaCreacion = fechaCreacion;

                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Desea modificar el descuento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Guardar los cambios en la base de datos
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el descuento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }



        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del descuento a eliminar
            int id = int.Parse(TxtID.Text);

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea desactivar el descuento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Actualizar el Estado del descuento a 0
                    GrupoDescuento grupoDescuento = unitOfWork.Repository<GrupoDescuento>().ObtenerPorId(id);
                    grupoDescuento.Estado = false; // 0 representa falso

                    // Guardar los cambios en la base de datos
                    unitOfWork.Repository<GrupoDescuento>().Editar(grupoDescuento);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            LimpiarCampos();
        }

        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);
        }

        private void LimpiarCampos()
        {
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            TxtPorcentaje.Text = "";
            CBEstado.Checked = false;
            DTFCreacion.Value = DateTime.Now;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
