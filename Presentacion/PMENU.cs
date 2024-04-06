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
    }
}
