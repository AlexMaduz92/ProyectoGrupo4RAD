using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Datos;
using Datos.Base_de_Dato;
using Datos.Core;
using Datos.Modelo;
using Negocio;

namespace Presentacion
{
    public partial class PClientes : Form
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Cliented _cliented;

        public PClientes()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork();
            _cliented = new Cliented();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnCerrar.Click += BtnCerrar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnElimina_Click;
        }

        private void BtnElimina_Click(object sender, EventArgs e)
        {
            Cliente clienteSeleccionado = ObtenerClienteSeleccionado();

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Desea eliminar el cliente seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    clienteSeleccionado.Estado = false; // Cambiar el estado del cliente a false

                    // Guardar el objeto modificado en la base de datos
                    _unitOfWork.Repository<Cliente>().Editar(clienteSeleccionado);
                    _unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.clientesTableAdapter.Fill(this.proyectoRadDataSet2.Clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public List<CondiccionPago> ObtenerCondiccionesPago()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return unitOfWork.Repository<CondiccionPago>().ObtenerTodos().ToList();
            }
        }
        private void PClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet21.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter2.Fill(this.proyectoRadDataSet21.Clientes);

            int proximoId = ObtenerProximoId();
            TxtID.Text = proximoId.ToString();
            DGVClientes.CellDoubleClick += DGVClientes_CellContentDoubleClick;
            CBXCPago.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXGDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CBXCPago.SelectedIndexChanged += CBXCPago_SelectedIndexChanged;
            CBXGDescuento.SelectedIndexChanged += CBXGDescuento_SelectedIndexChanged;

            IEnumerable<GrupoDescuento> gruposDescuento = _unitOfWork.Repository<GrupoDescuento>().ObtenerTodos();

            var descripciones = gruposDescuento.Select(g => g.Descripcion).ToList();
            var bindingList = new BindingList<string>(descripciones);

            // Limpiar ComboBox
            CBXGDescuento.DataSource = bindingList;


            List<CondiccionPago> condiccionPagos = _cliented.ObtenerCondiccionesPago();
            CBXCPago.DataSource = condiccionPagos;
            CBXCPago.DisplayMember = "Descripcion";
            CBXCPago.ValueMember = "CondicionPagoId";


            CargarDatosEstadoActivo();
           

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
                maxId = context.Set<Cliente>().Max(g => g.ClienteId);
            }
            return maxId + 1;
        }


        private void CBXCPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            {

                var condicionPago = (CondiccionPago)CBXCPago.SelectedItem;


                LbIdPago.Text = condicionPago.CondicionPagoId.ToString();
            }
        }



        private void CBXGDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXGDescuento.SelectedItem != null)
            {
                // Obtener la descripción seleccionada en el ComboBox
                string descripcionSeleccionada = (string)CBXGDescuento.SelectedItem;

                var grupoDescuento = _unitOfWork.Repository<GrupoDescuento>().ObtenerTodos()
                    .FirstOrDefault(g => g.Descripcion == descripcionSeleccionada);

                if (grupoDescuento != null)
                {
                    // Mostrar el Id del GrupoDescuento en un Label
                    LbIdDescuento.Text = grupoDescuento.GrupoDescuentoId.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el grupo de descuento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void DGVClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVClientes.Rows[e.RowIndex];
                TxtID.Text = row.Cells["ClienteIdDataGridViewTextBoxColumn"].Value.ToString();
                TxtNombre.Text = row.Cells["NombresDataGridViewTextBoxColumn"].Value.ToString();
                TxtApellido.Text = row.Cells["ApellidosDataGridViewTextBoxColumn"].Value.ToString();
                TxtCodigo.Text = row.Cells["CodigoDataGridViewTextBoxColumn"].Value.ToString();
                CBEstado.Checked = Convert.ToBoolean(row.Cells["EstadoDataGridViewCheckBoxColumn"].Value);
                DTFCreacion.Value = Convert.ToDateTime(row.Cells["FechaCreacionDataGridViewTextBoxColumn"].Value);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string codigo = TxtCodigo.Text;
            string apellido = TxtApellido.Text;
            string nombre = TxtNombre.Text;
            int condipago = 0;
            int Descuen = 0;
            bool estado = CBEstado.Checked;

            if (!int.TryParse(LbIdPago.Text, out condipago) || !int.TryParse(LbIdDescuento.Text, out Descuen))
            {
                MessageBox.Show("Error al obtener los valores de CondicionPagoId o GrupoDescuentoId.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fechaCreacion = DTFCreacion.Value;

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea guardar el cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(apellido))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Cliente clientess = new Cliente
                {
                    Codigo = codigo,
                    Nombres = nombre,
                    Estado = estado,
                    Apellidos = apellido,
                    CondicionPagoId = condipago,
                    GrupoDescuentoId = Descuen,
                    FechaCreacion = fechaCreacion
                };

                try
                {
                    // Guardar el objeto en la base de datos
                    _unitOfWork.Repository<Cliente>().Agregar(clientess);
                    _unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.clientesTableAdapter2.Fill(this.proyectoRadDataSet21.Clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            limpiar();
        }
        private Cliente ObtenerClienteSeleccionado()
        {
            if (DGVClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGVClientes.SelectedRows[0];
                int clienteId = Convert.ToInt32(row.Cells["ClienteIdDataGridViewTextBoxColumn"].Value);
                return _unitOfWork.Repository<Cliente>().ObtenerPorId(clienteId);
            }
            return null;
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener el cliente seleccionado
            Cliente cliente = ObtenerClienteSeleccionado();

            if (cliente != null)
            {
                // Actualizar los datos del cliente con los valores del formulario
                cliente.Codigo = TxtCodigo.Text;
                cliente.Nombres = TxtNombre.Text;
                cliente.Apellidos = TxtApellido.Text;
                cliente.Estado = CBEstado.Checked;
                cliente.CondicionPagoId = int.Parse(LbIdPago.Text);
                cliente.GrupoDescuentoId = int.Parse(LbIdDescuento.Text);
                cliente.FechaCreacion = DTFCreacion.Value;

                try
                {
                    // Modificar el cliente en la base de datos
                    _unitOfWork.Repository<Cliente>().Editar(cliente);
                    _unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    ActualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente para modificar.", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CBXFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = CBXFiltro.SelectedItem.ToString();
            if (filtro == "Activos")
            {
                CargarDatosEstadoActivo();
            }
            else if (filtro == "No Activos")
            {
                CargarDatosEstadoNoActivo();
            }
        }

        private void CargarDatosEstadoActivo()
        {
            DataView view = new DataView(this.proyectoRadDataSet21.Clientes);
            view.RowFilter = "Estado = true";
            DGVClientes.DataSource = view;
        }

        private void CargarDatosEstadoNoActivo()
        {
            DataView view = new DataView(this.proyectoRadDataSet21.Clientes);
            view.RowFilter = "Estado = false";
            DGVClientes.DataSource = view;
        }

        private void ActualizarDataGridView()
        {
            this.clientesTableAdapter2.Fill(this.proyectoRadDataSet21.Clientes);
        }

        private void limpiar()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            CBEstado.Checked = false;
        }
    }
}
