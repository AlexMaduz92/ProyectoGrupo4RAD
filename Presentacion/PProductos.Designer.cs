namespace Presentacion
{
    partial class PProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DTFCreacion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CBXCodCategoria = new System.Windows.Forms.ComboBox();
            this.CBXCodUMedida = new System.Windows.Forms.ComboBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.proyectoRadDataSet8 = new Presentacion.ProyectoRadDataSet8();
            this.pedidoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoesTableAdapter = new Presentacion.ProyectoRadDataSet8TableAdapters.PedidoesTableAdapter();
            this.proyectoRadDataSet9 = new Presentacion.ProyectoRadDataSet9();
            this.productoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoesTableAdapter = new Presentacion.ProyectoRadDataSet9TableAdapters.ProductoesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proyectoRadDataSet10 = new Presentacion.ProyectoRadDataSet10();
            this.productoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoesTableAdapter1 = new Presentacion.ProyectoRadDataSet10TableAdapters.ProductoesTableAdapter();
            this.productoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadMedidaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo unidad de medida:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(738, 211);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(117, 50);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(602, 211);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(117, 50);
            this.BtnModificar.TabIndex = 21;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(462, 211);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(117, 50);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // DTFCreacion
            // 
            this.DTFCreacion.Location = new System.Drawing.Point(655, 64);
            this.DTFCreacion.Name = "DTFCreacion";
            this.DTFCreacion.Size = new System.Drawing.Size(302, 26);
            this.DTFCreacion.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de creación:";
            // 
            // CBEstado
            // 
            this.CBEstado.AutoSize = true;
            this.CBEstado.Location = new System.Drawing.Point(211, 202);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(78, 24);
            this.CBEstado.TabIndex = 24;
            this.CBEstado.Text = "Activo";
            this.CBEstado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Precio de compra:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(211, 61);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(204, 26);
            this.TxtID.TabIndex = 26;
            // 
            // CBXCodCategoria
            // 
            this.CBXCodCategoria.FormattingEnabled = true;
            this.CBXCodCategoria.Location = new System.Drawing.Point(211, 103);
            this.CBXCodCategoria.Name = "CBXCodCategoria";
            this.CBXCodCategoria.Size = new System.Drawing.Size(204, 28);
            this.CBXCodCategoria.TabIndex = 27;
            // 
            // CBXCodUMedida
            // 
            this.CBXCodUMedida.FormattingEnabled = true;
            this.CBXCodUMedida.Location = new System.Drawing.Point(211, 147);
            this.CBXCodUMedida.Name = "CBXCodUMedida";
            this.CBXCodUMedida.Size = new System.Drawing.Size(204, 28);
            this.CBXCodUMedida.TabIndex = 28;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(211, 241);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(204, 26);
            this.TxtPrecio.TabIndex = 29;
            // 
            // proyectoRadDataSet8
            // 
            this.proyectoRadDataSet8.DataSetName = "ProyectoRadDataSet8";
            this.proyectoRadDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoesBindingSource
            // 
            this.pedidoesBindingSource.DataMember = "Pedidoes";
            this.pedidoesBindingSource.DataSource = this.proyectoRadDataSet8;
            // 
            // pedidoesTableAdapter
            // 
            this.pedidoesTableAdapter.ClearBeforeFill = true;
            // 
            // proyectoRadDataSet9
            // 
            this.proyectoRadDataSet9.DataSetName = "ProyectoRadDataSet9";
            this.proyectoRadDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoesBindingSource
            // 
            this.productoesBindingSource.DataMember = "Productoes";
            this.productoesBindingSource.DataSource = this.proyectoRadDataSet9;
            // 
            // productoesTableAdapter
            // 
            this.productoesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productoIdDataGridViewTextBoxColumn,
            this.categoriaIdDataGridViewTextBoxColumn,
            this.unidadMedidaIdDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productoesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // proyectoRadDataSet10
            // 
            this.proyectoRadDataSet10.DataSetName = "ProyectoRadDataSet10";
            this.proyectoRadDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoesBindingSource1
            // 
            this.productoesBindingSource1.DataMember = "Productoes";
            this.productoesBindingSource1.DataSource = this.proyectoRadDataSet10;
            // 
            // productoesTableAdapter1
            // 
            this.productoesTableAdapter1.ClearBeforeFill = true;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            this.productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            this.productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoriaIdDataGridViewTextBoxColumn
            // 
            this.categoriaIdDataGridViewTextBoxColumn.DataPropertyName = "CategoriaId";
            this.categoriaIdDataGridViewTextBoxColumn.HeaderText = "CategoriaId";
            this.categoriaIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoriaIdDataGridViewTextBoxColumn.Name = "categoriaIdDataGridViewTextBoxColumn";
            this.categoriaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // unidadMedidaIdDataGridViewTextBoxColumn
            // 
            this.unidadMedidaIdDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedidaId";
            this.unidadMedidaIdDataGridViewTextBoxColumn.HeaderText = "UnidadMedidaId";
            this.unidadMedidaIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unidadMedidaIdDataGridViewTextBoxColumn.Name = "unidadMedidaIdDataGridViewTextBoxColumn";
            this.unidadMedidaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.Width = 150;
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioCompra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "PrecioCompra";
            this.precioCompraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            this.precioCompraDataGridViewTextBoxColumn.Width = 150;
            // 
            // PProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.CBXCodUMedida);
            this.Controls.Add(this.CBXCodCategoria);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DTFCreacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PProductos";
            this.Load += new System.EventHandler(this.PProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DateTimePicker DTFCreacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CBEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox CBXCodCategoria;
        private System.Windows.Forms.ComboBox CBXCodUMedida;
        private System.Windows.Forms.TextBox TxtPrecio;
        private ProyectoRadDataSet8 proyectoRadDataSet8;
        private System.Windows.Forms.BindingSource pedidoesBindingSource;
        private ProyectoRadDataSet8TableAdapters.PedidoesTableAdapter pedidoesTableAdapter;
        private ProyectoRadDataSet9 proyectoRadDataSet9;
        private System.Windows.Forms.BindingSource productoesBindingSource;
        private ProyectoRadDataSet9TableAdapters.ProductoesTableAdapter productoesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoRadDataSet10 proyectoRadDataSet10;
        private System.Windows.Forms.BindingSource productoesBindingSource1;
        private ProyectoRadDataSet10TableAdapters.ProductoesTableAdapter productoesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
    }
}