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
    public partial class PDestalleFactura : Form
    {
        public PDestalleFactura()
        {
            InitializeComponent();
        }

        private void PDestalleFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet11.FacturaDetalles' Puede moverla o quitarla según sea necesario.
            this.facturaDetallesTableAdapter.Fill(this.proyectoRadDataSet11.FacturaDetalles);

        }
    }
}
