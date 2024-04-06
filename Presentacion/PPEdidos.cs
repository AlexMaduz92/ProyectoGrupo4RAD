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
    public partial class PPEdidos : Form
    {
        public PPEdidos()
        {
            InitializeComponent();
        }

        private void PPEdidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet5.Pedidoes' Puede moverla o quitarla según sea necesario.
            this.pedidoesTableAdapter.Fill(this.proyectoRadDataSet5.Pedidoes);

        }
    }
}
