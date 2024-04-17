using System;
using System.Collections.Generic;
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
        }

        private void PClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet14.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.proyectoRadDataSet14.Clientes);
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
            if (CBXCPago.SelectedItem != null)
            {
                // Obtener el objeto seleccionado en el ComboBox
                var condicionPago = (CondiccionPago)CBXCPago.SelectedItem;

                // Mostrar el Id de la condición de pago en el Label
                LbIdPago.Text = condicionPago.CondicionPagoId.ToString();
            }
        }

        private void CBXGDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXGDescuento.SelectedItem != null)
            {
                // Obtener el objeto seleccionado en el ComboBox
                var grupoDescuento = (GrupoDescuento)CBXGDescuento.SelectedItem;

                // Mostrar el Id del grupo de descuento en el Label
                LbIdDescuento.Text = grupoDescuento.GrupoDescuentoId.ToString();
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
            int condipago = LbIdPago.Text.Length;
            int Descuen=LbIdDescuento.Text.Length;
            bool estado = CBEstado.Checked;

            DateTime fechaCreacion = DTFCreacion.Value;

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea guardar el descuento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    this.clientesTableAdapter.Fill(this.proyectoRadDataSet2.Clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            limpiar();
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
            DataView view = new DataView(this.proyectoRadDataSet14.Clientes);
            view.RowFilter = "Estado = true";
            DGVClientes.DataSource = view;
        }

        private void CargarDatosEstadoNoActivo()
        {
            DataView view = new DataView(this.proyectoRadDataSet14.Clientes);
            view.RowFilter = "Estado = false";
            DGVClientes.DataSource = view;
        }

        private void ActualizarDataGridView()
        {
            this.clientesTableAdapter1.Fill(this.proyectoRadDataSet14.Clientes);
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
