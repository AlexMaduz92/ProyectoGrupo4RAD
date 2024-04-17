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
        public partial class PFactura : Form
        {
        private readonly UnitOfWork unitOfWork;
        public PFactura()
            {
                InitializeComponent();
                 unitOfWork = new UnitOfWork();
                 BtnGuardar.Click += BtnGuardar_Click;
                 BtnModificar.Click += BtnModificar_Click;
                 BtnEliminar.Click += BtnEliminar_Click;
            }

        private void PFactura_Load(object sender, EventArgs e)
        {
            // Obtener el próximo ID al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TXTID.Text = proximoId.ToString();

            // Cargar datos al datadiv
            this.facturasTableAdapter.Fill(this.proyectoRadDataSet6.Facturas);

            // Asignar el evento CellDoubleClick al DataGridView
            DGVFactura.CellDoubleClick += dgvFactura_CellContentDoubleClick;

            // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
            DataView dv = new DataView(this.proyectoRadDataSet6.Facturas);
            dv.RowFilter = "Estado = true";

            // Asignar el DataView filtrado al DataGridView
            DGVFactura.DataSource = dv;
        }

        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<Factura>().Max(g => g.FacturaId);
            }
            return maxId + 1;
        }

        private void dgvFactura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = DGVFactura.Rows[e.RowIndex];
                    TXTID.Text = row.Cells["FacturaIdDataGridViewTextBoxColumn"].Value.ToString();
                    CBEstado.Checked = Convert.ToBoolean(row.Cells["EstadoDataGridViewCheckBoxColumn"].Value);
                    DTFechaCreación.Value = Convert.ToDateTime(row.Cells["FechaCreacionDataGridViewTextBoxColumn"].Value);
                    DTFechaFactura.Value = Convert.ToDateTime(row.Cells["FechaFacturaDataGridViewTextBoxColumn"].Value);
                    TxtTotal.Text = row.Cells["TotalDataGridViewTextBoxColumn"].Value.ToString();
                    TxtSubTotal.Text = row.Cells["SubtotalDataGridViewTextBoxColumn"].Value.ToString();
                    TxtDescuento.Text = row.Cells["DescuentoDataGridViewTextBoxColumn"].Value.ToString();
                }

            }

            void limpiar()
            {
                TxtSubTotal.Text = "";
                TxtDescuento.Text = "";
                TxtTotal.Text = "";
                CBEstado.Checked = false;
            }

            private void BtnGuardar_Click(object sender, EventArgs e)
            {
                // Obtener los datos del formulario
                string subtotal = TxtSubTotal.Text;
                string descuento = TxtDescuento.Text;
                string total = TxtTotal.Text;
                int estado = CBEstado.Checked ? 1 : 0;


            DateTime fechaCreacion = DTFechaCreación.Value;
                DateTime fechaFactura = DTFechaFactura.Value;

                // mensaje de confirmacion
                DialogResult result = MessageBox.Show("¿Esta seguro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(subtotal) || string.IsNullOrWhiteSpace(descuento))
                    {
                        MessageBox.Show("Debe completar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Factura facturass = new Factura
                    {
                        Subtotal = decimal.Parse(subtotal),
                        Descuento = decimal.Parse(descuento),
                        Total = decimal.Parse(total),
                        Estado = estado,
                        ClienteId = int.Parse(CBXClienteId.SelectedValue.ToString()),
                        PedidoId = int.Parse(CBXPedidoId.SelectedValue.ToString()),
                        FechaCreacion = fechaCreacion,
                        FechaFactura = fechaFactura,
                    };

                    try
                    {
                    //Guardar en la db
                        unitOfWork.Repository<Factura>().Agregar(facturass);
                        unitOfWork.Guardar();

                        // Actualizar el datadiv
                        this.facturasTableAdapter.Fill(this.proyectoRadDataSet6.Facturas);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ActualizarDataGridView();
                limpiar();
            }



          

            private void ActualizarDataGridView()
            {
                // Actualizar el DataGridView
                this.facturasTableAdapter.Fill(this.proyectoRadDataSet6.Facturas);
            }

            private void BtnEliminar_Click(object sender, EventArgs e)
            {
                BtnModificar.Enabled = false;
                BtnGuardar.Enabled = false;
                // Obtener el ID del cliente a eliminar
                int id = int.Parse(TXTID.Text);

                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Desea eliminar la factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        
                        Factura facturass = unitOfWork.Repository<Factura>().ObtenerPorId(id);
                        facturass.Estado = 0; 

                        //Guardar los cambios en la base de datos
                        unitOfWork.Repository<Factura>().Editar(facturass);
                        unitOfWork.Guardar();

                        // Actualizar el DataGridView
                        this.facturasTableAdapter.Fill(this.proyectoRadDataSet6.Facturas);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ActualizarDataGridView();
                limpiar();
            }

            public void BtnModificar_Click(object sender, EventArgs e)
            {
                // Obtener los datos del formulario
                int id = int.Parse(TXTID.Text);
                decimal subtotal = decimal.Parse(TxtSubTotal.Text);
                decimal descuento = decimal.Parse(TxtDescuento.Text);
                decimal total = decimal.Parse(TxtTotal.Text);
                int estado = CBEstado.Checked ? 1 : 0;


            DateTime fechaCreacion = DTFechaCreación.Value;

                try
                {
                    // Obtener el GrupoDescuento existente desde el contexto
                    Factura facturass = unitOfWork.Repository<Factura>().ObtenerPorId(id);

                    // Modificar las propiedades del objeto existente
                    facturass.Subtotal = subtotal;
                    facturass.Descuento = descuento;
                    facturass.Estado = estado;
                    facturass.Total = total;
                    facturass.FechaCreacion = fechaCreacion;
                    facturass.FechaFactura = DTFechaFactura.Value;

                    // Mensaje de confirmación
                    DialogResult result = MessageBox.Show("¿Desea modificar la factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Guardar los cambios en la base de datos
                        unitOfWork.Guardar();

                        // Actualizar el datadiv
                        this.facturasTableAdapter.Fill(this.proyectoRadDataSet6.Facturas);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiar();
            }
    }
}