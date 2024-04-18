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

        }


        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<PedidoDetalle>().Max(g => g.PedidoDetalleId);
            }
            return maxId + 1;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)

        {
            // Validar que se haya seleccionado un producto
            if (CBXCodProducto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya ingresado la fecha de creacion
            if (DTFechaCreación.Value == null)
            {
                MessageBox.Show("Debe ingresar la fecha de creacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya ingresado el total
            if (string.IsNullOrEmpty(TxtTotal.Text))
            {
                MessageBox.Show("Debe ingresar el total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya ingresado el descuento
            if (string.IsNullOrEmpty(TxtDescuento.Text))
            {
                MessageBox.Show("Debe ingresar el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear un nuevo objeto Pedido con los datos de los controles del formulario
            PedidoDetalle pedido = new PedidoDetalle
            {
                ProductoId = (int)CBXCodProducto.SelectedItem,
                PedidoId=(int)CBXCpedido.SelectedItem,
                FechaCreacion = DateTime.Now, // Por ejemplo, la fecha actual
                Total = decimal.Parse(TxtTotal.Text),
                Descuento = decimal.Parse(TxtDescuento.Text),
                Precio=decimal.Parse(TxtPrecio.Text),
                // Otras propiedades del Pedido que desees establecer
            };

            // Guardar el pedido si todas las validaciones son exitosas
            nPedidoDetalle.GuardarPedidoDetalle(pedido);
            MessageBox.Show("Pedido guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.pedidoDetallesTableAdapter.Fill(this.proyectoRadDataSet7.PedidoDetalles); ;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            int productiid = int.Parse(CBXCodProducto.Text);
            int pedidoid=int.Parse(CBXCpedido.Text);
            DateTime fechaCreacion = DTFechaCreación.Value;
            decimal total = decimal.Parse(TxtTotal.Text);
            decimal descuento = decimal.Parse(TxtDescuento.Text);
            decimal precio = decimal.Parse(TxtPrecio.Text);


            DialogResult result = MessageBox.Show("¿Desea modificar el pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
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
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el pedido con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);

            DialogResult result = MessageBox.Show("¿Desea eliminar el pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var unitOfWork = new UnitOfWork())
                    {
                        var pedido = unitOfWork.Repository<PedidoDetalle>().ObtenerPorId(id);

                        if (pedido != null)
                        {
                            pedido.PedidoDetalleId = 0;


                            unitOfWork.Guardar();

                            MessageBox.Show("Pedido eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGridView();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el pedido con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            TxtID.Text = "";
            CBXCodProducto.Text = "";
            CBXCpedido.Text = "";
            DTFechaCreación.Value = DateTime.Now;
            TxtDescuento.Text = "";
            TxtTotal.Text = "";
            TxtPrecio.Text = "";
        }

        private void CBXCpedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCpedido.SelectedItem != null)
            {
                int clienteId = (int)CBXCpedido.SelectedItem;
                string nombreCliente = nPedidoDetalle.ObtenerPedidoPorId(clienteId);
                TxtPedidoSelecionado.Text = nombreCliente;
                string total=nPedidoDetalle.ObtenerTotalPorId(clienteId);
                TxtTotal.Text= total;
                string descuento=nPedidoDetalle.ObtenerPedidoDescuentoPorId(clienteId);
                TxtDescuento.Text= descuento;
               
            }
        }

        private void CBXCodProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCodProducto.SelectedItem != null)
            {
                int clienteId = (int)CBXCodProducto.SelectedItem;
                string nombreCliente = nPedidoDetalle.ObtenerCodigoProductoPorId(clienteId);
                CBXProductoSeleccionado.Text = nombreCliente;

                string precio=nPedidoDetalle.ObtenerCodigoProductoPrecioPorId(clienteId);
                TxtPrecio.Text= precio;
            }

        }

        private void PDetallePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet7.PedidoDetalles' Puede moverla o quitarla según sea necesario.
            this.pedidoDetallesTableAdapter.Fill(this.proyectoRadDataSet7.PedidoDetalles);

            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();
            CBXCpedido.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXCodProducto.DropDownStyle = ComboBoxStyle.DropDownList;

            List<int> idsproducto = nPedidoDetalle.ObtenerIdsProductos(); // Debes implementar este método en la capa de negocio
            foreach (int idCliente in idsproducto)
            {
                CBXCodProducto.Items.Add(idCliente);
            }

            List<int> idspedido = nPedidoDetalle.ObtenerIdsPedidos(); // Debes implementar este método en la capa de negocio
            foreach (int idCliente in idspedido)
            {
                CBXCpedido.Items.Add(idCliente);
            }
        }
    }
}


