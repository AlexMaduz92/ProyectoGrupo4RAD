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
    public partial class PCondicionesPago : Form
    {
        public PCondicionesPago()
        {
            InitializeComponent();
        }

        private void PCondicionesPago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet4.CondiccionPagoes' Puede moverla o quitarla según sea necesario.
            this.condiccionPagoesTableAdapter.Fill(this.proyectoRadDataSet4.CondiccionPagoes);

        }
    }
}
