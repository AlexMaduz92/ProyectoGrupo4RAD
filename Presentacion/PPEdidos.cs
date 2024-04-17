using Datos.Base_de_Dato;
using Datos.Core;
using Datos.Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class PPEdidos : Form
    {
        private Pedidos _pedidosNegocio;
        public PPEdidos()
        {
            _pedidosNegocio = new Pedidos();
            InitializeComponent();
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            BtnCerrar.Click += BtnCerrar_Click;
            CBXCodCliente.SelectedIndexChanged += CBXCodCliente_SelectedIndexChanged;
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

        private void PPEdidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet13.Pedidoes' Puede moverla o quitarla según sea necesario.
            this.pedidoesTableAdapter1.Fill(this.proyectoRadDataSet13.Pedidoes);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet5.Pedidoes' Puede moverla o quitarla según sea necesario.
            this.pedidoesTableAdapter.Fill(this.proyectoRadDataSet5.Pedidoes);
            CBXFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXCodCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            //CBXProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            DGVPedidos.CellDoubleClick += DGVPedidos_CellDoubleClick;


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

            List<int> idsClientes = _pedidosNegocio.ObtenerIdsClientes(); // Debes implementar este método en la capa de negocio
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
                string nombreCliente = _pedidosNegocio.ObtenerNombreClientePorId(clienteId);
                TxtNCliente.Text = nombreCliente;
            }
        }

        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<Pedido>().Max(g => g.PedidoId);
            }
            return maxId + 1;
        }

        private void DGVPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVPedidos.Rows[e.RowIndex];
                // Obtener el valor de la celda en la columna 0 (PedidoId)
                TxtID.Text = row.Cells["PedidoIdDataGridViewTextBoxColumn"].Value.ToString();
                CBXCodCliente.Text = row.Cells["ClienteIdDataGridViewTextBoxColumn"].Value.ToString();
                DTFechaCreación.Value = Convert.ToDateTime(row.Cells["FechaCreacionDataGridViewTextBoxColumn"].Value);
                DTFechaPedido.Value = Convert.ToDateTime(row.Cells["FechaPedidoDataGridViewTextBoxColumn"].Value);
                CBEstado.Checked = Convert.ToBoolean(row.Cells["EstadoDataGridViewTextBoxColumn"].Value);
                TxtTotal.Text = row.Cells["TotalDataGridViewTextBoxColumn"].Value.ToString();
                TxtSubTotal.Text = row.Cells["SubtotalDataGridViewTextBoxColumn"].Value.ToString();
                TxtDescuento.Text = row.Cells["DescuentoDataGridViewTextBoxColumn"].Value.ToString();

            }
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un cliente
            if (CBXCodCliente.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya ingresado la fecha de pedido
            if (DTFechaPedido.Value == null)
            {
                MessageBox.Show("Debe ingresar la fecha de pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar el pedido como activo?", "Estado del Pedido", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            bool estado = false; // 0 por defecto, inactivo
            if (dialogResult == DialogResult.Yes)
            {
                estado = true; // Si elige "Sí", el estado será activo
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return; // Si elige "Cancelar", se cancela la operación de guardado
            }

            // Crear un nuevo objeto Pedido con los datos de los controles del formulario
            Pedido pedido = new Pedido
            {
                ClienteId = (int)CBXCodCliente.SelectedItem,
                FechaCreacion = DateTime.Now, // Por ejemplo, la fecha actual
                FechaPedido = DTFechaPedido.Value, // Obtener la fecha de pedido del control DateTimePicker
                Total = decimal.Parse(TxtTotal.Text),
                Subtotal = decimal.Parse(TxtSubTotal.Text),
                Descuento = decimal.Parse(TxtDescuento.Text),
                Estado = estado
                // Otras propiedades del Pedido que desees establecer
            };

            // Guardar el pedido si todas las validaciones son exitosas
            _pedidosNegocio.GuardarPedido(pedido);
            MessageBox.Show("Pedido guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ActualizarDataGridView();
        }


        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.pedidoesTableAdapter.Fill(this.proyectoRadDataSet5.Pedidoes); ;
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
               if (DGVPedidos.Columns[e.ColumnIndex].Name == "Estado") // Reemplaza "Estado" con el nombre real de la columna
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
            int clienteId = int.Parse(CBXCodCliente.Text);
            DateTime fechaCreacion = DTFechaCreación.Value;
            DateTime fechaPedido = DTFechaPedido.Value;
            decimal total = decimal.Parse(TxtTotal.Text);
            decimal subtotal = decimal.Parse(TxtSubTotal.Text);
            decimal descuento = decimal.Parse(TxtDescuento.Text);
            bool estado = CBEstado.Checked; // Convertir el valor del CheckBox a booleano

            DialogResult result = MessageBox.Show("¿Desea modificar el pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var unitOfWork = new UnitOfWork())
                    {
                        var pedido = unitOfWork.Repository<Pedido>().ObtenerPorId(id);

                        if (pedido != null)
                        {
                            pedido.ClienteId = clienteId;
                            pedido.FechaCreacion = fechaCreacion;
                            pedido.FechaPedido = fechaPedido;
                            pedido.Total = total;
                            pedido.Subtotal = subtotal;
                            pedido.Descuento = descuento;
                            pedido.Estado = estado;

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
                        var pedido = unitOfWork.Repository<Pedido>().ObtenerPorId(id);

                        if (pedido != null)
                        {
                            pedido.Estado = false;


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
            CBXCodCliente.Text = "";
            CBEstado.Text = "";
            DTFechaPedido.Value = DateTime.Now;
            DTFechaCreación.Value = DateTime.Now;
            CBEstado.Checked = false;
            TxtSubTotal.Text = "";
            TxtDescuento.Text = "";
            TxtTotal.Text = "";
        }





        private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.proyectoRadDataSet5.Pedidoes);
            view.RowFilter = "Estado = true";
            DGVPedidos.DataSource = view;
        }
        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.proyectoRadDataSet5.Pedidoes);
            view.RowFilter = "Estado = false";
            DGVPedidos.DataSource = view;
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
