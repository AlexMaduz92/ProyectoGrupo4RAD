using Negocio;
using System;
using System.Windows.Forms;
using Datos.Modelo;
using System.Collections.Generic;
using Datos;
using Datos.Base_de_Dato;
using System.Linq;
using Datos.Core;

namespace Presentacion
{
    public partial class PDetallePedido : Form
    {
        private readonly NPedidoDetalle nPedidoDetalle;

        public PDetallePedido()
        {
            InitializeComponent();
            nPedidoDetalle = new NPedidoDetalle();
            CBXCodProducto.SelectedIndexChanged += CBXCodProducto_SelectedIndexChanged;
            CBXCpedido.SelectedIndexChanged += CBXCpedido_SelectedIndexChanged;
            BtnGuardar.Click += BtnGuardar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            BtnCerrar.Click += BtnCerrar_Click;
            DGVDPedido.CellDoubleClick += DGVDPedido_CellDoubleClick;

        }



        private void PDetallePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet20.PedidoDetalles' Puede moverla o quitarla según sea necesario.
            this.pedidoDetallesTableAdapter2.Fill(this.proyectoRadDataSet20.PedidoDetalles);


            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();
            CBXCpedido.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXCodProducto.DropDownStyle = ComboBoxStyle.DropDownList;

            List<int> idsproducto = nPedidoDetalle.ObtenerIdsProductos();
            foreach (int idCliente in idsproducto)
            {
                CBXCodProducto.Items.Add(idCliente);
            }

            List<int> idspedido = nPedidoDetalle.ObtenerIdsPedidos();
            foreach (int idCliente in idspedido)
            {
                CBXCpedido.Items.Add(idCliente);
            }
        }

        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<PedidoDetalle>().Select(g => (int?)g.PedidoDetalleId).Max() ?? 0;
            }
            return maxId + 1;
        }


        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVDPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <DGVDPedido.Rows.Count)
            {
                DataGridViewRow row = DGVDPedido.Rows[e.RowIndex];
                TxtID.Text = row.Cells[0].Value.ToString();
                CBXCpedido.SelectedItem = row.Cells[1].Value;
                CBXCodProducto.SelectedItem = row.Cells[2].Value;
                DTFechaCreación.Value = (DateTime)row.Cells[6].Value;
                TxtTotal.Text = row.Cells[4].Value.ToString();
                TxtDescuento.Text = row.Cells[5].Value.ToString();
                TxtPrecio.Text = row.Cells[3].Value.ToString();
            }
        }

        private bool pedidoGuardado = false;

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (pedidoGuardado)
            {
                MessageBox.Show("El pedido ya se ha guardado. No es posible guardar nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validar datos
                if (CBXCodProducto.SelectedItem == null || DTFechaCreación.Value == null || string.IsNullOrEmpty(TxtTotal.Text) || string.IsNullOrEmpty(TxtDescuento.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear objeto PedidoDetalle
                PedidoDetalle pedido = new PedidoDetalle
                {
                    ProductoId = (int)CBXCodProducto.SelectedItem,
                    PedidoId = (int)CBXCpedido.SelectedItem,
                    FechaCreacion = DateTime.Now,
                    Total = decimal.Parse(TxtTotal.Text),
                    Descuento = decimal.Parse(TxtDescuento.Text),
                    Precio = decimal.Parse(TxtPrecio.Text)
                };

                // Guardar pedido
                nPedidoDetalle.GuardarPedidoDetalle(pedido);
                MessageBox.Show("Pedido guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDataGridView();
                ObtenerProximoId();
                LimpiarCampos();

                pedidoGuardado = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos Total, Descuento y Precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ActualizarDataGridView()
        {
            this.pedidoDetallesTableAdapter2.Fill(this.proyectoRadDataSet20.PedidoDetalles);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtID.Text);
                int productiid = int.Parse(CBXCodProducto.Text);
                int pedidoid = int.Parse(CBXCpedido.Text);
                DateTime fechaCreacion = DTFechaCreación.Value;
                decimal total = decimal.Parse(TxtTotal.Text);
                decimal descuento = decimal.Parse(TxtDescuento.Text);
                decimal precio = decimal.Parse(TxtPrecio.Text);

                DialogResult result = MessageBox.Show("¿Desea modificar el pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var unitOfWork = new UnitOfWork())
                    {
                        var pedido = unitOfWork.Repository<PedidoDetalle>().ObtenerPorId(id);

                        if (pedido != null)
                        {
                            pedido.ProductoId = productiid;
                            pedido.PedidoId = pedidoid;
                            pedido.FechaCreacion = fechaCreacion;
                            pedido.Total = total;
                            pedido.Descuento = descuento;
                            pedido.Precio = precio;

                            unitOfWork.Guardar();

                            MessageBox.Show("Pedido modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGridView();
                            ObtenerProximoId();
                            LimpiarCampos();

                            // Marcar el pedido como guardado
                            pedidoGuardado = true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el pedido con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos Total, Descuento y Precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(TxtID.Text);

                DialogResult result = MessageBox.Show("¿Desea eliminar el pedido?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var unitOfWork = new UnitOfWork())
                    {
                        var pedido = unitOfWork.Repository<PedidoDetalle>().ObtenerPorId(id);

                        if (pedido != null)
                        {
                            unitOfWork.Repository<PedidoDetalle>().Eliminar(pedido);
                            unitOfWork.Guardar();

                            MessageBox.Show("Pedido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGridView();
                            ObtenerProximoId();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el pedido con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                if (!(ex is FormatException))
                {
                    MessageBox.Show($"Error al eliminar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void LimpiarCampos()
        {
            TxtID.Text = "";
            CBXCodProducto.Text = "";
            TxtPedidoSelecionado.Text = "";
            CBXCodProducto.Text = "";
            CBXCpedido.Text = "";
            DTFechaCreación.Value = DateTime.Now;
            TxtDescuento.Text = "";
            CBXProductoSeleccionado.Text = "";
            TxtTotal.Text = "";
            TxtPrecio.Text = "";

        }

        private void CBXCpedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCpedido.SelectedItem != null)
            {
                try
                {
                    int clienteId = (int)CBXCpedido.SelectedItem;
                    string nombreCliente = nPedidoDetalle.ObtenerPedidoPorId(clienteId);
                    if (!string.IsNullOrEmpty(nombreCliente))
                    {
                        TxtPedidoSelecionado.Text = nombreCliente;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el pedido con el ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string total = nPedidoDetalle.ObtenerTotalPorId(clienteId);
                    if (!string.IsNullOrEmpty(total))
                    {
                        TxtTotal.Text = total;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el total para el pedido con el ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string descuento = nPedidoDetalle.ObtenerPedidoDescuentoPorId(clienteId);
                    if (!string.IsNullOrEmpty(descuento))
                    {
                        TxtDescuento.Text = descuento;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el descuento para el pedido con el ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener información del pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CBXCodProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCodProducto.SelectedItem != null)
            {
                try
                {
                    int clienteId = (int)CBXCodProducto.SelectedItem;
                    string nombreCliente = nPedidoDetalle.ObtenerCodigoProductoPorId(clienteId);
                    if (!string.IsNullOrEmpty(nombreCliente))
                    {
                        CBXProductoSeleccionado.Text = nombreCliente;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto con el ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string precio = nPedidoDetalle.ObtenerCodigoProductoPrecioPorId(clienteId);
                    if (!string.IsNullOrEmpty(precio))
                    {
                        TxtPrecio.Text = precio;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el precio para el producto con el ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener información del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}


