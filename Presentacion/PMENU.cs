using Negocio;
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
    public partial class PMENU : Form
    {
        public PMENU()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
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
            PUnidadMedida umedidaForm = new PUnidadMedida();
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

        private void detalleDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDestalleFactura detallefacturaform = new PDestalleFactura();
            detallefacturaform.ShowDialog();
        }

        private void detalleDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PDetallePedido detallepedidoorm = new PDetallePedido();
            detallepedidoorm.ShowDialog();
        }
    }
}
