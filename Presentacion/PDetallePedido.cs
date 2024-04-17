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
    public partial class PDetallePedido : Form
    {
        private DetallePedido _detallePedidoNegocio;
        public PPEdidos()
        {
            _detallePedidoNegocio = new detallePedido();
            InitializeComponent();
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            BtnCerrar.Click += BtnCerrar_Click;
            BtnGuardar.Click += BtnGuardar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;

            // Suscribir los eventos de cambio de texto
            TxtSubTotal.TextChanged += TxtSubTotal_TextChanged;
            TxtDescuento.TextChanged += TxtDescuento_TextChanged;

            // Inicializar los campos de texto
            TxtSubTotal.Text = "0";
            TxtDescuento.Text = "0";
            TxtTotal.Text = "0";
        }

        private void PDetallePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet13.detallePedidos' Puede moverla o quitarla según sea necesario.
            this.detallePedidosTableAdapter1.Fill(this.proyectoRadDataSet13.detallePedidos);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet5.detallePedidos' Puede moverla o quitarla según sea necesario.
            this.detallePedidosTableAdapter.Fill(this.proyectoRadDataSet5.detallePedidos);
            CBXFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            //CBXProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            DGVDetallePedido.CellDoubleClick += DGVDetallePedido_CellDoubleClick;


            CargarDatosEstadoActivo();
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();

            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();

            List<int> idsClientes = _detallePedidoNegocio.ObtenerIdsClientes(); // Debes implementar este método en la capa de negocio
            foreach (int idCliente in idsClientes)
            {
                CBXCodCliente.Items.Add(idCliente);
            }

        }

        private void CBXCodCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCodCliente.SelectedItem != null)
            {
                int clienteId = (int)CBXCodCliente.SelectedItem;
                string nombreCliente = _detallePedidoNegocio.ObtenerNombreClientePorId(clienteId);
                TxtNCliente.Text = nombreCliente;
            }
        }
        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<DetatallePedido>().Max(g => g.PedidoDetalleId);
            }
            return maxId + 1;


        }

        private void DGVDetallePedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVDetallePedido.Rows[e.RowIndex];
                // Obtener el valor de la celda en la columna 0 (PedidoDetalleId)
                TxtID.Text = row.Cells["PedidoDetalleIdDataGridViewTextBoxColumn"].Value.ToString();
                TxtID.Text = row.Cells["ProductoIdDataGridViewTextBoxColumn"].Value.ToString();
                TxtPrecio.Text = row.Cells["TotalDataGridViewTextBoxColumn"].Value.ToString();
                TxtSubTotal.Text = row.Cells["SubtotalDataGridViewTextBoxColumn"].Value.ToString();
                TxtDescuento.Text = row.Cells["DescuentoDataGridViewTextBoxColumn"].Value.ToString();
                DTFechaCreación.Value = Convert.ToDateTime(row.Cells["FechaCreacionDataGridViewTextBoxColumn"].Value);
                

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {


            // Validar que se haya ingresado la fecha Creación
            if (DTFechaCreación.Value == null)
            {
                MessageBox.Show("Debe ingresar la fecha de creación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya ingresado el total
            if (string.IsNullOrEmpty(TxtTotal.Text))
            {
                MessageBox.Show("Debe ingresar el total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya ingresado el subtotal
            if (string.IsNullOrEmpty(TxtSubTotal.Text))
            {
                MessageBox.Show("Debe ingresar el subtotal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya ingresado el descuento
            if (string.IsNullOrEmpty(TxtDescuento.Text))
            {
                MessageBox.Show("Debe ingresar el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar un cuadro de diálogo para que el usuario elija el estado
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar el DetallePedido como activo?", "Estado del DetallePedido", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            bool estado = false; // 0 por defecto, inactivo
            if (dialogResult == DialogResult.Yes)
            {
                estado = true; // Si elige "Sí", el estado será activo
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return; // Si elige "Cancelar", se cancela la operación de guardado
            }

            // Crear un nuevo objeto DetallePedido con los datos de los controles del formulario
            DetallePedido Detallepedido = new DetallePedido
            {
            
                PedidoId = (int)CBXCpedido.SelectedItem,
                ProductoId = (int)CBXProducto.SelectedItem,
                Precio = decimal.Parse(TxtPrecio.Text),
                Total = decimal.Parse(TxtTotal.Text),
                Descuento = decimal.Parse(TxtDescuento.Text),
                FechaCreacion = DateTime.Now, // Por ejemplo, la fecha actual
                Estado = estado
                // Otras propiedades del DetallePedido que desees establecer
            };

            // Guardar el pedido si todas las validaciones son exitosas
            _detallePedidoNegocio.GuardarDetallePedido(detallepedido);
            MessageBox.Show("DetallePedido guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.detallePedidosTableAdapter.Fill(this.proyectoRadDataSet5.detallePedidos); ;
        }


        private void TxtSubTotal_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (decimal.TryParse(TxtSubTotal.Text, out decimal subtotal) &&
                decimal.TryParse(TxtDescuento.Text, out decimal descuento))
            {
                decimal total = subtotal - (subtotal * (descuento / 100));
                TxtTotal.Text = total.ToString();
            }
            else
            {
                TxtTotal.Text = "";
            }
        }

        /*   private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
           {
               if (DGVDetallePedido.Columns[e.ColumnIndex].Name == "Estado") // Reemplaza "Estado" con el nombre real de la columna
               {
                   if (e.Value is bool)
                   {
                       bool value = (bool)e.Value;
                       e.Value = value ? "true" : "false";
                       e.FormattingApplied = true;
                   }
               }
           } */

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            int pedidoId = int.Parse(CBXCodPedido.Text);
            int productoId = int.Parse(CBXCodProducto.Text);
            decimal precio = decimal.Parse(TxtPrecio.Text);
            decimal total = decimal.Parse(TxtTotal.Text);
            decimal descuento = decimal.Parse(TxtDescuento.Text);
            DateTime fechaCreacion = DTFechaCreación.Value;
            bool estado = CBEstado.Checked; // Convertir el valor del CheckBox a booleano

            DialogResult result = MessageBox.Show("¿Desea modificar el detallepedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var unitOfWork = new UnitOfWork())
                    {
                        var detallepedido = unitOfWork.Repository<Pedido>().ObtenerPorId(id);

                        if (detallepedido != null)
                        {
                            detallepedido.PedidoId = pedidoId;
                            detallepedido.ProductoId = productoId;
                            detallepedido.Precio = precio;
                            detallepedido.Total = total;
                            detallepedido.Descuento = descuento;
                            detallepedido.FechaCreacion = fechaCreacion;
                            detallepedido.Estado = estado;

                            unitOfWork.Guardar();

                            MessageBox.Show("DetallePedido modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGridView();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el detallepedido con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el detallepedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);

            DialogResult result = MessageBox.Show("¿Desea eliminar el DetallePedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var unitOfWork = new UnitOfWork())
                    {
                        var detallepedido = unitOfWork.Repository<DeatallePedido>().ObtenerPorId(id);

                        if (detallepedido != null)
                        {
                            detallepedido.Estado = false;


                            unitOfWork.Guardar();

                            MessageBox.Show("DetallePedido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGridView();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el detallepedido con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el detallepedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            TxtPedidoID.Text = "";
            TxtProductoID.Text = "";
            TxtPrecioID.Text = "";
            CBEstado.Text = "";
            TxtSubTotal.Text = "";
            TxtDescuento.Text = "";
            DTFechaCreación.Value = DateTime.Now;
            CBEstado.Checked = false;
            
        }

        private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.proyectoRadDataSet5.DetallesPedidos);
            view.RowFilter = "Estado = true";
            DGVDetallePedido.DataSource = view;
        }
        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.proyectoRadDataSet5.DetallePedidos);
            view.RowFilter = "Estado = false";
            DGVDetallePedido.DataSource = view;
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

