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
    public partial class PFactura : Form
    {
        public PFactura()
        {
            InitializeComponent();
        }

        private void PFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet6.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.proyectoRadDataSet6.Facturas);

        }
    }
}
