namespace Presentacion
{
    partial class PDetallePedido
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
            this.DTFechaCreación = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CBXCpedido = new System.Windows.Forms.ComboBox();
            this.TxtPedidoSelecionado = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DGVDPedido = new System.Windows.Forms.DataGridView();
            this.pedidoDetalleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoDetallesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRadDataSet15 = new Presentacion.ProyectoRadDataSet15();
            this.pedidoDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRadDataSet7 = new Presentacion.ProyectoRadDataSet7();
            this.pedidoDetallesTableAdapter = new Presentacion.ProyectoRadDataSet7TableAdapters.PedidoDetallesTableAdapter();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBXCodProducto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CBXProductoSeleccionado = new System.Windows.Forms.TextBox();
            this.pedidoDetallesTableAdapter1 = new Presentacion.ProyectoRadDataSet15TableAdapters.PedidoDetallesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETALLE DE PEDIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo de pedido:";
            // 
            // DTFechaCreación
            // 
            this.DTFechaCreación.Location = new System.Drawing.Point(732, 49);
            this.DTFechaCreación.Margin = new System.Windows.Forms.Padding(2);
            this.DTFechaCreación.Name = "DTFechaCreación";
            this.DTFechaCreación.Size = new System.Drawing.Size(216, 20);
            this.DTFechaCreación.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(541, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha de creación:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.Red;
            this.TxtTotal.Location = new System.Drawing.Point(732, 117);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(216, 22);
            this.TxtTotal.TabIndex = 34;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Enabled = false;
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtDescuento.Location = new System.Drawing.Point(732, 83);
            this.TxtDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(216, 22);
            this.TxtDescuento.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(541, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(541, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Pedido seleccionado:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(277, 52);
            this.TxtID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(209, 20);
            this.TxtID.TabIndex = 36;
            // 
            // CBXCpedido
            // 
            this.CBXCpedido.FormattingEnabled = true;
            this.CBXCpedido.Location = new System.Drawing.Point(276, 83);
            this.CBXCpedido.Margin = new System.Windows.Forms.Padding(2);
            this.CBXCpedido.Name = "CBXCpedido";
            this.CBXCpedido.Size = new System.Drawing.Size(210, 21);
            this.CBXCpedido.TabIndex = 37;
            this.CBXCpedido.SelectedIndexChanged += new System.EventHandler(this.CBXCpedido_SelectedIndexChanged);
            // 
            // TxtPedidoSelecionado
            // 
            this.TxtPedidoSelecionado.Enabled = false;
            this.TxtPedidoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPedidoSelecionado.Location = new System.Drawing.Point(275, 117);
            this.TxtPedidoSelecionado.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPedidoSelecionado.Name = "TxtPedidoSelecionado";
            this.TxtPedidoSelecionado.Size = new System.Drawing.Size(211, 22);
            this.TxtPedidoSelecionado.TabIndex = 38;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEliminar.Location = new System.Drawing.Point(905, 185);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(78, 32);
            this.BtnEliminar.TabIndex = 41;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(815, 185);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(78, 32);
            this.BtnModificar.TabIndex = 40;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(721, 185);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(78, 32);
            this.BtnGuardar.TabIndex = 39;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DGVDPedido
            // 
            this.DGVDPedido.AllowUserToDeleteRows = false;
            this.DGVDPedido.AutoGenerateColumns = false;
            this.DGVDPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pedidoDetalleIdDataGridViewTextBoxColumn,
            this.pedidoIdDataGridViewTextBoxColumn,
            this.productoIdDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn});
            this.DGVDPedido.DataSource = this.pedidoDetallesBindingSource1;
            this.DGVDPedido.Location = new System.Drawing.Point(11, 245);
            this.DGVDPedido.Margin = new System.Windows.Forms.Padding(2);
            this.DGVDPedido.Name = "DGVDPedido";
            this.DGVDPedido.ReadOnly = true;
            this.DGVDPedido.RowHeadersWidth = 62;
            this.DGVDPedido.RowTemplate.Height = 28;
            this.DGVDPedido.Size = new System.Drawing.Size(982, 180);
            this.DGVDPedido.TabIndex = 42;
            // 
            // pedidoDetalleIdDataGridViewTextBoxColumn
            // 
            this.pedidoDetalleIdDataGridViewTextBoxColumn.DataPropertyName = "PedidoDetalleId";
            this.pedidoDetalleIdDataGridViewTextBoxColumn.HeaderText = "PedidoDetalleId";
            this.pedidoDetalleIdDataGridViewTextBoxColumn.Name = "pedidoDetalleIdDataGridViewTextBoxColumn";
            this.pedidoDetalleIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidoIdDataGridViewTextBoxColumn
            // 
            this.pedidoIdDataGridViewTextBoxColumn.DataPropertyName = "PedidoId";
            this.pedidoIdDataGridViewTextBoxColumn.HeaderText = "PedidoId";
            this.pedidoIdDataGridViewTextBoxColumn.Name = "pedidoIdDataGridViewTextBoxColumn";
            this.pedidoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            this.productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            this.productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            this.productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidoDetallesBindingSource1
            // 
            this.pedidoDetallesBindingSource1.DataMember = "PedidoDetalles";
            this.pedidoDetallesBindingSource1.DataSource = this.proyectoRadDataSet15;
            // 
            // proyectoRadDataSet15
            // 
            this.proyectoRadDataSet15.DataSetName = "ProyectoRadDataSet15";
            this.proyectoRadDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoDetallesBindingSource
            // 
            this.pedidoDetallesBindingSource.DataMember = "PedidoDetalles";
            this.pedidoDetallesBindingSource.DataSource = this.proyectoRadDataSet7;
            // 
            // proyectoRadDataSet7
            // 
            this.proyectoRadDataSet7.DataSetName = "ProyectoRadDataSet7";
            this.proyectoRadDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoDetallesTableAdapter
            // 
            this.pedidoDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(980, -2);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(27, 21);
            this.BtnCerrar.TabIndex = 68;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(277, 206);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(208, 22);
            this.TxtPrecio.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Precio producto:";
            // 
            // CBXCodProducto
            // 
            this.CBXCodProducto.FormattingEnabled = true;
            this.CBXCodProducto.Location = new System.Drawing.Point(275, 147);
            this.CBXCodProducto.Margin = new System.Windows.Forms.Padding(2);
            this.CBXCodProducto.Name = "CBXCodProducto";
            this.CBXCodProducto.Size = new System.Drawing.Size(211, 21);
            this.CBXCodProducto.TabIndex = 74;
            this.CBXCodProducto.SelectedIndexChanged += new System.EventHandler(this.CBXCodProducto_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 25);
            this.label10.TabIndex = 73;
            this.label10.Text = "Codigo de producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 168);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 25);
            this.label11.TabIndex = 75;
            this.label11.Text = "Producto seleccionado:";
            // 
            // CBXProductoSeleccionado
            // 
            this.CBXProductoSeleccionado.Enabled = false;
            this.CBXProductoSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBXProductoSeleccionado.Location = new System.Drawing.Point(275, 174);
            this.CBXProductoSeleccionado.Margin = new System.Windows.Forms.Padding(2);
            this.CBXProductoSeleccionado.Name = "CBXProductoSeleccionado";
            this.CBXProductoSeleccionado.Size = new System.Drawing.Size(210, 22);
            this.CBXProductoSeleccionado.TabIndex = 76;
            // 
            // pedidoDetallesTableAdapter1
            // 
            this.pedidoDetallesTableAdapter1.ClearBeforeFill = true;
            // 
            // PDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1004, 440);
            this.Controls.Add(this.CBXProductoSeleccionado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CBXCodProducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DGVDPedido);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtPedidoSelecionado);
            this.Controls.Add(this.CBXCpedido);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DTFechaCreación);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PDetallePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDetallePedido";
            this.Load += new System.EventHandler(this.PDetallePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTFechaCreación;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox CBXCpedido;
        private System.Windows.Forms.TextBox TxtPedidoSelecionado;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DGVDPedido;
        private ProyectoRadDataSet7 proyectoRadDataSet7;
        private System.Windows.Forms.BindingSource pedidoDetallesBindingSource;
        private ProyectoRadDataSet7TableAdapters.PedidoDetallesTableAdapter pedidoDetallesTableAdapter;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoDetalleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBXCodProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CBXProductoSeleccionado;
        private ProyectoRadDataSet15 proyectoRadDataSet15;
        private System.Windows.Forms.BindingSource pedidoDetallesBindingSource1;
        private ProyectoRadDataSet15TableAdapters.PedidoDetallesTableAdapter pedidoDetallesTableAdapter1;
    }
}