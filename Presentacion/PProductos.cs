using Datos;
using Datos.Base_de_Dato;
using Datos.Core;
using Datos.Modelo;
using Negocio;
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
        private readonly UnitOfWork unitOfWork;
        private Productod productod;
        public PProductos()
        {
            productod= new Productod();
            BtnCerrar.Click += BtnCerrar_Click;
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            BtnGuardar.Click += BtnGuardar_Click;
            BtnModificar.Click += BtnModificar_Click;
            BtnEliminar.Click += BtnEliminar_Click;
            CBXCodCategoria.SelectedIndexChanged += CBXCodCategoria_SelectedIndexChanged;
            CBXCodUMedida.SelectedIndexChanged += CBXCodUMedida_SelectedIndexChanged;
        }

        private void PProductos_Load(object sender, EventArgs e)
        {
            // Obtener el próximo ID que se generará al guardar
            int proximoId = ObtenerProximoId();

            // Mostrar el próximo ID en el TxtID
            TxtID.Text = proximoId.ToString();

            // Cargar datos en el DataGridView
            this.productoesTableAdapter.Fill(this.proyectoRadDataSet9.Productoes);

            // Asignar el evento CellDoubleClick al DataGridView
            DbProducto.CellDoubleClick += DbProducto_CellContentDoubleClick;

            // Crear un DataView y aplicar un filtro para mostrar solo los registros con Estado en true
            DataView dv = new DataView(this.proyectoRadDataSet9.Productoes);
            dv.RowFilter = "Estado = true";

            // Asignar el DataView filtrado al DataGridView
            DbProducto.DataSource = dv;

            CBXCodCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXCodUMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarDatosEstadoActivo();
            CBXFiltro.Items.Add("Activos");
            CBXFiltro.Items.Add("No Activos");
            CBXFiltro.SelectedIndex = 0;
            CBXFiltro.SelectedIndexChanged += CBXFiltro_SelectedIndexChanged;
            CargarDatosEstadoActivo();

            List<int> idcategoria = productod.ObtenerIdcategoria(); // Debes implementar este método en la capa de negocio
            foreach (int idCate in idcategoria)
            {
                CBXCodCategoria.Items.Add(idCate);
            }
            List<int> idunidad = productod.ObtenerIdUnidadMeida(); // Debes implementar este método en la capa de negocio
            foreach (int iduni in idunidad)
            {
                CBXCodCategoria.Items.Add(iduni);
            }

        }
        private int ObtenerProximoId()
        {
            int maxId = 0;
            using (var context = new Exaconection())
            {
                maxId = context.Set<Producto>().Max(g => g.ProductoId);
            }
            return maxId + 1;
        }
        private void ActualizarDataGridView()
        {
            // Actualizar el DataGridView
            this.productoesTableAdapter.Fill(this.proyectoRadDataSet9.Productoes);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
     

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea guardar el descuento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Mostrar un cuadro de diálogo para que el usuario elija el estado
                DialogResult dialogResult = MessageBox.Show("¿Desea guardar el pedido como activo?", "Estado del Pedido", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                bool estado = false; // 0 por defecto, inactivo
                if (dialogResult == DialogResult.Yes)
                {
                    estado = true; // Si elige "Sí", el estado será activo
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    return; // Si elige "Cancelar", se cancela la operación de guardado
                }

                Producto prod = new Producto
                {
                    PrecioCompra= int.Parse(TxtPrecio.Text),
                    Estado= estado,
                    CategoriaId = (int)CBXCodCategoria.SelectedItem,
                    UnidadMedidaId = (int)CBXCodCategoria.SelectedItem,
                    FechaCreacion = DateTime.Now,
                };

                try
                {
                    // Guardar el objeto en la base de datos
                    unitOfWork.Repository<Producto>().Agregar(prod);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.productoesTableAdapter.Fill(this.proyectoRadDataSet9.Productoes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            LimpiarCampos();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            int catecliente = int.Parse(CBXCodCategoria.Text);
            int unidad = int.Parse(CBXCodUMedida.Text);
            DateTime fechaCreacion = DTFCreacion.Value;
            decimal precio = decimal.Parse(TxtPrecio.Text);
            bool estado = CBEstado.Checked; // Convertir el valor del CheckBox a booleano

            DialogResult result = MessageBox.Show("¿Desea modificar el Producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var unitOfWork = new UnitOfWork())
                    {
                        var prodc = unitOfWork.Repository<Producto>().ObtenerPorId(id);

                        if (prodc != null)
                        {
                            prodc.CategoriaId = catecliente;
                            prodc.FechaCreacion = fechaCreacion;
                            prodc.UnidadMedidaId = unidad;
                            prodc.PrecioCompra = precio;
                            prodc.Estado = estado;

                            unitOfWork.Guardar();

                            MessageBox.Show("Pedido modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGridView();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el  Producto con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el Producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
            // Obtener el ID del cliente a eliminar
            int id = int.Parse(TxtID.Text);

            // Mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Desea eliminar un Producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Actualizar el Estado del descuento a 0
                    Producto prod = unitOfWork.Repository<Producto>().ObtenerPorId(id);
                    prod.Estado = false; // 0 representa falso

                    // Guardar los cambios en la base de datos
                    unitOfWork.Repository<Producto>().Editar(prod);
                    unitOfWork.Guardar();

                    // Actualizar el DataGridView
                    this.productoesTableAdapter.Fill(this.proyectoRadDataSet9.Productoes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ActualizarDataGridView();
            LimpiarCampos();
        }
        private void CargarDatosEstadoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = true
            DataView view = new DataView(this.proyectoRadDataSet9.Productoes);
            view.RowFilter = "Estado = true";
            DbProducto.DataSource = view;
        }
        private void CargarDatosEstadoNoActivo()
        {
            // Crear una nueva vista de datos filtrada por Estado = false
            DataView view = new DataView(this.proyectoRadDataSet9.Productoes);
            view.RowFilter = "Estado = false";
            DbProducto.DataSource = view;
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

        private void CBXCodCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCodCategoria.SelectedItem != null)
            {
                int Condid = (int)CBXCodCategoria.SelectedItem;
                string codigo = productod.ObtenerCategoriaClientePorId(Condid);
                TxtID.Text = codigo;
            }
        }

        private void CBXCodUMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBXCodUMedida.SelectedItem != null)
            {
                int Condid = (int)CBXCodUMedida.SelectedItem;
                string codigo = productod.ObtenerUnidadMedidaPorId(Condid);
                TxtID.Text = codigo;
            }

        }

        private void DbProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se haya seleccionado una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DbProducto.Rows[e.RowIndex];
                // Obtener el valor de la celda en la columna 0 (PedidoId)
                TxtID.Text = row.Cells["ProductoIdDataGridViewTextBoxColumn"].Value.ToString();
                CBXCodCategoria.Text = row.Cells["CategoriaIdDataGridViewTextBoxColumn"].Value.ToString();
                CBXCodUMedida.Text = row.Cells["UnidadMedidaIdDataGridViewTextBoxColumn"].Value.ToString();
                DTFCreacion.Value = Convert.ToDateTime(row.Cells["FechaCreacionDataGridViewTextBoxColumn"].Value);
                CBEstado.Checked = Convert.ToBoolean(row.Cells["EstadoDataGridViewTextBoxColumn"].Value);
                TxtPrecio.Text = row.Cells["PrecioCompraDataGridViewTextBoxColumn"].Value.ToString();
                

            }
        }
        private void LimpiarCampos()
        {
            TxtID.Text = "";
            CBXCodCategoria.Text = "";
            CBEstado.Text = "";
            DTFCreacion.Value = DateTime.Now;
            CBEstado.Checked = false;
            CBXCodUMedida.Text = "";
            TxtPrecio.Text = "";
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
