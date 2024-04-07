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
    public partial class PProductos : Form
    {
        public PProductos()
        {
            InitializeComponent();
        }

        private void PProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet10.Productoes' Puede moverla o quitarla según sea necesario.
            this.productoesTableAdapter1.Fill(this.proyectoRadDataSet10.Productoes);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet9.Productoes' Puede moverla o quitarla según sea necesario.
            this.productoesTableAdapter.Fill(this.proyectoRadDataSet9.Productoes);
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet8.Pedidoes' Puede moverla o quitarla según sea necesario.
            this.pedidoesTableAdapter.Fill(this.proyectoRadDataSet8.Pedidoes);

        }
    }
}
