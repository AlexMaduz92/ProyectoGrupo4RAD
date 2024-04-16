using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Modelo;
using Negocio;
using Datos.Base_de_Dato;
using Datos.Core;

namespace Presentacion
{
    public partial class PClientes : Form
    {
        private readonly UnitOfWork unitOfWork;
        private Cliented cliented;
      
        public PClientes()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            CBXCPago.SelectedIndexChanged += CBXCPago_SelectedIndexChanged;
            CBXGDescuento.SelectedIndexChanged += CBXGDescuento_SelectedIndexChanged;

        }
        
        

    private void PClientes_Load(object sender, EventArgs e)
        {

            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();

            // Cargar datos en el DataGridView
            this.clientesTableAdapter.Fill(this.proyectoRadDataSet2.Clientes);

            // Asignar el evento CellDoubleClick al DataGridView
            DGVClientes.CellDoubleClick += DGVClientes_CellContentDoubleClick;

            // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
            DataView dv = new DataView(this.proyectoRadDataSet2.Clientes);
            dv.RowFilter = "Estado = true";

            // Asignar el DataView filtrado al DataGridView
            DGVClientes.DataSource = dv;
            
            CBXCPago.DropDownStyle = ComboBoxStyle.DropDownList;

            CargarDatosEstadoActivo();
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();

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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string codigo = TxtCodigo.Text;
            string apellido= TxtApellido.Text;
            string nombre = TxtNombre.Text;
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
                    CondicionPagoId = (int)CBXCPago.SelectedItem,
                    GrupoDescuentoId = int.Parse(CBXGDescuento.SelectedValue.ToString()),
                    FechaCreacion = fechaCreacion
                };

                try
                {
                    // Guardar el objeto en la base de datos
                    unitOfWork.Repository<Cliente>().Agregar(clientess);
                    unitOfWork.Guardar();

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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
            // Obtener el ID del cliente a eliminar
            int id = int.Parse(TxtID.Text);

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea eliminar un cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Actualizar el Estado del descuento a 0
                    Cliente clientess = unitOfWork.Repository<Cliente>().ObtenerPorId(id);
                    clientess.Estado = false; // 0 representa falso

                    // Guardar los cambios en la base de datos
                    unitOfWork.Repository<Cliente>().Editar(clientess);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.clientesTableAdapter.Fill(this.proyectoRadDataSet2.Clientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            limpiar();

        }

        void limpiar()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            CBEstado.Checked = false;
        }

  
        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.clientesTableAdapter.Fill(this.proyectoRadDataSet2.Clientes);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            int id = int.Parse(TxtID.Text);
            string codigo = TxtCodigo.Text;
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            bool estado = CBEstado.Checked;
         
            DateTime fechaCreacion = DTFCreacion.Value;
            try
            {
                // Obtener el GrupoDescuento existente desde el contexto
                Cliente clientess = unitOfWork.Repository<Cliente>().ObtenerPorId(id);

                // Modificar las propiedades del objeto existente
                clientess.Codigo = codigo;
                clientess.Nombres = nombre;
                clientess.Estado = estado;
                clientess.Apellidos = apellido;
                clientess.FechaCreacion = fechaCreacion;

                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Desea modificar al cliente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Guardar los cambios en la base de datos
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.clientesTableAdapter.Fill(this.proyectoRadDataSet2.Clientes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiar();
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

        private void CBXCPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBXCPago.SelectedItem != null)
            {
                int Condid = (int)CBXCPago.SelectedItem;
                string codigo = cliented.ObtenerCondicionPorId(Condid);
                TxtCodigo.Text = codigo;
            }
        }

        private void CBXGDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXGDescuento.SelectedItem != null)
            {
                int Condid = (int)CBXGDescuento.SelectedItem;
                string codigo = cliented.ObtenerDescuentoPorId(Condid);
                TxtCodigo.Text = codigo;
            }

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.proyectoRadDataSet2.Clientes);
            view.RowFilter = "Estado = true";
            DGVClientes.DataSource = view;
        }
        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.proyectoRadDataSet2.Clientes);
            view.RowFilter = "Estado = false";
            DGVClientes.DataSource = view;
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
    }
}
