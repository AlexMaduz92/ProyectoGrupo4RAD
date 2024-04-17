using Negocio;
using System;
using System.Windows.Forms;
using Datos.Modelo;
using System.Collections.Generic;
using Datos;

namespace Presentacion
{
    public partial class PDetallePedido : Form
    {
        private readonly NPedidoDetalle nPedidoDetalle;

        public PDetallePedido()
        {
            InitializeComponent();
            nPedidoDetalle = new NPedidoDetalle();

            BtnCerrar.Click += BtnCerrar_Click;

        }

        private void PDetallePedido_Load(object sender, EventArgs e)
        {
            
           
                // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet15.PedidoDetalles' Puede moverla o quitarla según sea necesario.
                this.pedidoDetallesTableAdapter1.Fill(this.proyectoRadDataSet15.PedidoDetalles);


        }



        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

