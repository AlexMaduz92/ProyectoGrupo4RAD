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

namespace Presentacion
{
    public partial class PClientes : Form
    {
        Dclientes dclientes;
        Cliented cliented;
        public PClientes()
        {
            InitializeComponent();
            cargardatos();
        }

        private void PClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet2.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.proyectoRadDataSet2.Clientes);

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            {
                cliente.ClienteId = int.Parse(TxtID.Text);
                cliente.Codigo=TxtCodigo.Text;
                cliente.Nombres=TxtNombre.Text;
                cliente.Apellidos = TxtApellido.Text;
                //cliente.GrupoDescuento = int.Parse(CBXGDescuento.SelectedValue.ToString());
                cliente.Estado = CBEstado.Checked;
                cliente.FechaCreacion = DateTime.Now;

            }
            cliented.Guardar(cliente);
            cargardatos();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
            string clien = TxtID.Text;

            if (string.IsNullOrEmpty(clien) || string.IsNullOrWhiteSpace(clien))
            {
                errorProvider1.SetError(TxtID, "Debe seleccionar un Cliente para eliminar");
                return;
            }


            dclientes.Eliminar(int.Parse(clien));

            limpiar();

        }

        void limpiar()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            CBEstado.Checked = false;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

            TxtID.Text = DGVClientes.CurrentRow.Cells["ClienteId"].Value.ToString();
            TxtCodigo.Text = DGVClientes.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtNombre.Text = DGVClientes.CurrentRow.Cells["Nombres"].Value.ToString();
            TxtApellido.Text = DGVClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            CBEstado.Checked = bool.Parse(DGVClientes.CurrentRow.Cells["Estado"].Value.ToString());
        }

        void cargardatos()
        {
         
        }

        private void DGVClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }
    }
}
