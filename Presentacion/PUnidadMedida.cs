﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public partial class PUnidadMedida : Form
    {
        public PUnidadMedida()
        {
            InitializeComponent();
        }

        private void PUnidadMedida_Load(object sender, EventArgs e)
        {
           
        }

        private void PUnidadMedida_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet3.UnidadMedidas' Puede moverla o quitarla según sea necesario.
            this.unidadMedidasTableAdapter.Fill(this.proyectoRadDataSet3.UnidadMedidas);

        }
    }
}
