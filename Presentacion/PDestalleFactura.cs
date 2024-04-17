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
        public partial class PDestalleFactura : Form
        {
            private readonly UnitOfWork unitOfWork;
            public PDestalleFactura()
            {
                InitializeComponent();
                UnitOfWork unitOfWork = new UnitOfWork();
                BtnGuardar.Click += BtnGuardar_Click;
                BtnModificar.Click += BtnModificar_Click;
                BtnEliminar.Click += BtnEliminar_Click;
            }

        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<FacturaDetalle>().Max(g => g.FacturaId);
            }
            return maxId + 1;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    TxtID.Text = row.Cells["FacturaDetalleIdDataGridViewTextBoxColumn"].Value.ToString();
                    DTFCreacion.Value = Convert.ToDateTime(row.Cells["FechaCreacionDataGridViewTextBoxColumn"].Value);
                    TxtTotal.Text = row.Cells["TotalDataGridViewTextBoxColumn"].Value.ToString();
                    TxtSubTotal.Text = row.Cells["SubtotalDataGridViewTextBoxColumn"].Value.ToString();
                    TxtDescuento.Text = row.Cells["DescuentoDataGridViewTextBoxColumn"].Value.ToString();
                    TxtPrecio.Text = row.Cells["PrecioDataGridViewTextBoxColumn"].Value.ToString();
                }
            }

            void limpiar()
            {
                TxtSubTotal.Text = "";
                TxtDescuento.Text = "";
                TxtTotal.Text = "";
                TxtPrecio.Text = "";
            }

            private void ActualizarDataGridView()
            {
                // Actualizar el datadiv
                this.facturaDetallesTableAdapter.Fill(this.proyectoRadDataSet11.FacturaDetalles);
            }

            private void BtnGuardar_Click(object sender, EventArgs e)
            {
                // Obtener los datos del formulario
                string subtotal = TxtSubTotal.Text;
                string descuento = TxtDescuento.Text;
                string total = TxtTotal.Text;
                string precio = TxtPrecio.Text;


                DateTime fechaCreacion = DTFCreacion.Value;

                // mensaje de confirmacion
                DialogResult result = MessageBox.Show("¿Esta seguro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(subtotal) && string.IsNullOrWhiteSpace(total))
                    {
                        MessageBox.Show("Debe completar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    FacturaDetalle facturaDetalles = new FacturaDetalle
                    {
                        SubTotal = decimal.Parse(subtotal),
                        Descuento = decimal.Parse(descuento),
                        Total = decimal.Parse(total),
                        Precio = decimal.Parse(precio),
                        FacturaId = int.Parse(CBXCodFactura.SelectedValue.ToString()),
                        ProductoId = int.Parse(CBXCodProducto.SelectedValue.ToString()),
                        FechaCreacion = fechaCreacion,
                    };

                    try
                    {
                    //Guardar en la db
                    unitOfWork.Repository<FacturaDetalle>().Agregar(facturaDetalles);
                    unitOfWork.Guardar();

                        // Actualizar el datadiv
                        this.facturaDetallesTableAdapter.Fill(this.proyectoRadDataSet11.FacturaDetalles);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar los detalles de la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ActualizarDataGridView();
                limpiar();

            }

            private void PDestalleFactura_Load(object sender, EventArgs e)
            {
                // Obtener el próximo ID al guardar
                int proximoId = ObtenerProximoId();

                // Mostrar el próximo ID en el TxtID
                TxtID.Text = proximoId.ToString();

                // Cargar datos al datadiv
                this.facturaDetallesTableAdapter.Fill(this.proyectoRadDataSet11.FacturaDetalles);

                // Asignar el evento CellDoubleClick al DataGridView
                dataGridView1.CellContentDoubleClick += DGVFacturaDetalle_CellContentDoubleClick;

                // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
                DataView dv = new DataView(this.proyectoRadDataSet11.FacturaDetalles);
                dv.RowFilter = "Estado = true";

                // Asignar el DataView filtrado al DataGridView
                 dataGridView1.DataSource = dv;

            }

            private void BtnEliminar_Click(object sender, EventArgs e)
            {
                BtnModificar.Enabled = false;
                BtnGuardar.Enabled = false;
                // Obtener el ID del cliente a eliminar
                int id = int.Parse(TxtID.Text);

                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Desea eliminar la factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Actualizar el Estado del descuento a 0
                        FacturaDetalle facturaDetalle= unitOfWork.Repository<FacturaDetalle>().ObtenerPorId(id);
                        facturaDetalle.Estado = 0;

                    //Guardar los cambios en la base de datos
                    unitOfWork.Repository<FacturaDetalle>().Editar(facturaDetalle);
                    unitOfWork.Guardar();

                        // Actualizar el DataGridView
                        this.facturaDetallesTableAdapter.Fill(this.proyectoRadDataSet11.FacturaDetalles);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ActualizarDataGridView();
                limpiar();
            }

            private void BtnModificar_Click(object sender, EventArgs e)
            {
                // Obtener los datos del formulario
                int id = int.Parse(TxtID.Text);
                decimal subtotal = decimal.Parse(TxtSubTotal.Text);
                decimal descuento = decimal.Parse(TxtDescuento.Text);
                decimal total = decimal.Parse(TxtTotal.Text);
                decimal precio = decimal.Parse(TxtPrecio.Text);

                DateTime fechaCreacion = DTFCreacion.Value;

                try
                {
                    // Obtener el GrupoDescuento existente desde el contexto
                    FacturaDetalle facturaDetalless = unitOfWork.Repository<FacturaDetalle>().ObtenerPorId(id);

                    // Modificar las propiedades del objeto existente
                    facturaDetalless.SubTotal = subtotal;
                    facturaDetalless.Descuento = descuento;
                    facturaDetalless.Total = total;
                    facturaDetalless.Precio = precio;

                    facturaDetalless.FechaCreacion = fechaCreacion;

                    // Mensaje de confirmación
                    DialogResult result = MessageBox.Show("¿Desea modificar la factura?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Guardar los cambios en la base de datos
                        unitOfWork.Guardar();

                        // Actualizar el datadiv
                        this.facturaDetallesTableAdapter.Fill(this.proyectoRadDataSet11.FacturaDetalles);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                limpiar();
            }

            private void DGVFacturaDetalle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                throw new NotImplementedException();
            }

            private void DGVFacturaDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                throw new NotImplementedException();
            }

            private void DGVFacturaDetalle_Click(object sender, EventArgs e)
            {
                throw new NotImplementedException();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }


        }
}