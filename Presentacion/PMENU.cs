using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PMENU : Form
    {
        public PMENU()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+ @"\images\LogoDebik.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Center;
        }


        private void agregaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCategoria categoriaForm = new PCategoria();
            categoriaForm.ShowDialog();
        }

        private void descuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDescuento descuentoForm = new PDescuento();
            descuentoForm.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PClientes clientesForm = new PClientes();
            clientesForm.ShowDialog();
        }

        private void unidadesDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PUMediDas umedidaForm = new PUMediDas();
            umedidaForm.ShowDialog();
        }

        private void condicionesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCondicionesPago cpagoForm = new PCondicionesPago();
            cpagoForm.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PPEdidos pedidoForm = new PPEdidos();
            pedidoForm.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PFactura facturaForm = new PFactura();
            facturaForm.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PProductos productosform = new PProductos();
            productosform.ShowDialog();
        }



        private void detalleDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDetallePedido detallepedidoorm = new PDetallePedido();
            detallepedidoorm.ShowDialog();
        }

        private void PMENU_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.PowderBlue;
                }
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manualDeUsuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                 string userManualPath = Path.Combine(Application.StartupPath, @"Manual\Manual.pdf");

                System.Diagnostics.Process.Start(userManualPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening user manual: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
