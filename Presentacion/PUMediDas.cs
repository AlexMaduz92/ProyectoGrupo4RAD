using Datos.Base_de_Dato;
using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class PUMediDas : Form
    {
        public PUMediDas()
        {
            InitializeComponent();
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            BtnCerrar.Click += BtnCerrar_Click;
        }

        private void PUMediDas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoRadDataSet17.UnidadMedidas' Puede moverla o quitarla según sea necesario.
            this.unidadMedidasTableAdapter.Fill(this.proyectoRadDataSet17.UnidadMedidas);

            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TXTIDS.Text = proximoId.ToString();
            CargarDatosEstadoActivo();
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();


        }

        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<UnidadMedida>().Max(g => g.UnidadMedidaId);
            }
            return maxId + 1;
        }

         private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.proyectoRadDataSet17.UnidadMedidas);
            view.RowFilter = "Estado = true";
            DGVUMedidas.DataSource = view;
        }
        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.proyectoRadDataSet17.UnidadMedidas);
            view.RowFilter = "Estado = false";
            DGVUMedidas.DataSource = view;
        }

        private void CBXFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el filtro seleccionado
            string filtro = CBXFiltro.SelectedItem.ToString();

            // Actualizar el DataGridView según el filtro seleccionado
            if (filtro == "Activos")
            {
                CargarDatosEstadoActivo();
            }
            else if (filtro == "No Activos")
            {
                CargarDatosEstadoNoActivo();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuarda_Click(object sender, EventArgs e)
        {
            string codigo = Txtcodig.Text;
            string descripcion = TxtDescrip.Text;
            bool estado = CBEstados.Checked;
            DateTime fechaCreacion = DTFcreaciones.Value;

            DialogResult result = MessageBox.Show("¿Desea guardar la medida?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UnidadMedida medida = new UnidadMedida
                {
                    Codigo = codigo,
                    Descripcion = descripcion,
                    Estado = estado,
                    FechaCreacion = fechaCreacion
                };

                try
                {
                    NUMedidas negocioMedidas = new NUMedidas();
                    negocioMedidas.GuardarMedida(medida);
                    MessageBox.Show("Medida guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar la medida: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

             // Limpiar los campos después de guardar
        }


    }
}
