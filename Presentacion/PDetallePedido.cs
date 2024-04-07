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
    public partial class PDetallePedido : Form
    {
        public PDetallePedido()
        {
            InitializeComponent();
        }

        private void PDetallePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet7.PedidoDetalles' Puede moverla o quitarla según sea necesario.
            this.pedidoDetallesTableAdapter.Fill(this.proyectoRadDataSet7.PedidoDetalles);

        }
    }
}
