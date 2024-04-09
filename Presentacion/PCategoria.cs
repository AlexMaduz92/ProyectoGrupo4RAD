using Datos;
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
    public partial class PCategoria : Form
    {
        Dcategorial dcategorial;
        public PCategoria()
        {
            InitializeComponent();
            cargardatos();
        }

        private void PCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.proyectoRadDataSet.Categorias);

        }
        void cargardatos()
        {
            var datos = dcategorial.TodasLascategorias().Select(c => new
            {
                c.CategoriaId,
                c.Codigo,
                c.Descripcion,
                c.Estado,
                c.FechaCreacion
            });

            DGVCategoria.DataSource = datos.ToList();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
            string clien = TxtID.Text;

            if (string.IsNullOrEmpty(clien) || string.IsNullOrWhiteSpace(clien))
            {
                errorProvider1.SetError(TxtID, "Debe seleccionar un Cliente para eliminar");
                return;
            }


            dcategorial.Eliminar(int.Parse(clien));

            limpiar();

        }

        void limpiar()
        {
            TxtID.Text = "";
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            CBEstado.Checked = false;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnGuardar.Enabled = false;

            TxtID.Text = DGVCategoria.CurrentRow.Cells["Categoriald"].Value.ToString();
            TxtCodigo.Text = DGVCategoria.CurrentRow.Cells["Codigo"].Value.ToString();
            TxtDescripcion.Text = DGVCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();
            DTFCreacion.Text = DGVCategoria.CurrentRow.Cells["FechaCreacion"].Value.ToString();
            CBEstado.Checked = bool.Parse(DGVCategoria.CurrentRow.Cells["Estado"].Value.ToString());
        }

        private void DGVCategoria_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
