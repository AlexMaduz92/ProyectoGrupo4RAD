﻿using Datos.Base_de_Dato;
using Datos.Core;
using Datos.Modelo;
using Negocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PDescuento : Form
    {
        private readonly UnitOfWork unitOfWork;

        public PDescuento()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            BtnCerrar.Click += BtnCerrar_Click;
        }

        private void PDescuento_Load(object sender, EventArgs e)
        {
            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();

            // Cargar datos en el DataGridView
            this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);

            // Asignar el evento CellDoubleClick al DataGridView
            DGVDescuento.CellDoubleClick += DGVDescuento_CellDoubleClick;

            // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
            DataView dv = new DataView(this.proyectoRadDataSet1.GrupoDescuentoes);
            dv.RowFilter = "Estado = true";

            // Asignar el DataView filtrado al DataGridView
            DGVDescuento.DataSource = dv;

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
                maxId = context.Set<GrupoDescuento>().Max(g => g.GrupoDescuentoId);
            }
            return maxId + 1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string codigo = TxtCodigo.Text;
            string descripcion = TxtDescripcion.Text;
            bool estado = CBEstado.Checked;
            decimal porcentaje;
            DateTime fechaCreacion = DTFCreacion.Value;

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea guardar el descuento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Debe completar todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(TxtPorcentaje.Text, out porcentaje))
                {
                    MessageBox.Show("Porcentaje debe ser un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Crear una instancia de la capa de negocio Descuento
                Descuento descuentoNegocio = new Descuento();

                // Crear un nuevo objeto GrupoDescuento
                GrupoDescuento grupoDescuento = new GrupoDescuento
                {
                    Codigo = codigo,
                    Descripcion = descripcion,
                    Estado = estado,
                    Porcentaje = porcentaje,
                    FechaCreacion = fechaCreacion
                };

                try
                {
                    // Guardar el objeto en la base de datos
                    descuentoNegocio.GuardarDescuento(grupoDescuento);

                    // Actualizar el DataGridView
                    this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el descuento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            LimpiarCampos();
        }


        private void DGVDescuento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVDescuento.Rows[e.RowIndex];
                TxtID.Text = row.Cells["GrupoDescuentoIdDataGridViewTextBoxColumn"].Value.ToString();
                TxtCodigo.Text = row.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString();
                TxtDescripcion.Text = row.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString();
                CBEstado.Checked = Convert.ToBoolean(row.Cells["estadoDataGridViewCheckBoxColumn"].Value);
                DTFCreacion.Value = Convert.ToDateTime(row.Cells["fechaCreacionDataGridViewTextBoxColumn"].Value);
                TxtPorcentaje.Text = row.Cells["porcentajeDataGridViewTextBoxColumn"].Value.ToString();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            int id = int.Parse(TxtID.Text);
            string codigo = TxtCodigo.Text;
            string descripcion = TxtDescripcion.Text;
            bool estado = CBEstado.Checked;
            decimal porcentaje;
            DateTime fechaCreacion = DTFCreacion.Value;

            if (!decimal.TryParse(TxtPorcentaje.Text, out porcentaje))
            {
                MessageBox.Show("Porcentaje debe ser un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una instancia de la capa de negocio Descuento
            Descuento descuentoNegocio = new Descuento();

            try
            {
                // Obtener el GrupoDescuento existente desde la capa de negocio
                Datos.Modelo.GrupoDescuento grupoDescuento = descuentoNegocio.ObtenerDescuentoPorId(id);

                // Modificar las propiedades del objeto existente
                grupoDescuento.Codigo = codigo;
                grupoDescuento.Descripcion = descripcion;
                grupoDescuento.Estado = estado;
                grupoDescuento.Porcentaje = porcentaje;
                grupoDescuento.FechaCreacion = fechaCreacion;

                // Mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Desea modificar el descuento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Guardar los cambios en la base de datos
                    descuentoNegocio.ModificarDescuento(grupoDescuento);

                    // Actualizar el DataGridView
                    this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el descuento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }




        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del descuento a eliminar
            int id = int.Parse(TxtID.Text);

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea desactivar el descuento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Crear una instancia de la capa de negocio Descuento
                Descuento descuentoNegocio = new Descuento();

                try
                {
                    // Actualizar el Estado del descuento a false
                    Datos.Modelo.GrupoDescuento grupoDescuento = descuentoNegocio.ObtenerDescuentoPorId(id);
                    grupoDescuento.Estado = false;

                    // Guardar los cambios en la base de datos
                    descuentoNegocio.ModificarDescuento(grupoDescuento);

                    // Actualizar el DataGridView
                    this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al desactivar el descuento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            LimpiarCampos();
        }


        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.grupoDescuentoesTableAdapter.Fill(this.proyectoRadDataSet1.GrupoDescuentoes);
        }

        private void LimpiarCampos()
        {
            TxtCodigo.Text = "";
            TxtDescripcion.Text = "";
            TxtPorcentaje.Text = "";
            CBEstado.Checked = false;
            DTFCreacion.Value = DateTime.Now;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.proyectoRadDataSet1.GrupoDescuentoes);
            view.RowFilter = "Estado = true";
            DGVDescuento.DataSource = view;
        }

        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.proyectoRadDataSet1.GrupoDescuentoes);
            view.RowFilter = "Estado = false";
            DGVDescuento.DataSource = view;
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
        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
