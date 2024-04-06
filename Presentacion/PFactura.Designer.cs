namespace Presentacion
{
    partial class PFactura
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
            this.DTFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.DTFechaCreación = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.CheckBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DGVFactura = new System.Windows.Forms.DataGridView();
            this.proyectoRadDataSet6 = new Presentacion.ProyectoRadDataSet6();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new Presentacion.ProyectoRadDataSet6TableAdapters.FacturasTableAdapter();
            this.facturaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.CBXClienteId = new System.Windows.Forms.ComboBox();
            this.CBXPedidoId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo pedido:";
            // 
            // DTFechaFactura
            // 
            this.DTFechaFactura.Location = new System.Drawing.Point(687, 105);
            this.DTFechaFactura.Name = "DTFechaFactura";
            this.DTFechaFactura.Size = new System.Drawing.Size(322, 26);
            this.DTFechaFactura.TabIndex = 21;
            // 
            // DTFechaCreación
            // 
            this.DTFechaCreación.Location = new System.Drawing.Point(687, 59);
            this.DTFechaCreación.Name = "DTFechaCreación";
            this.DTFechaCreación.Size = new System.Drawing.Size(322, 26);
            this.DTFechaCreación.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha de factura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha de creación:";
            // 
            // CBEstado
            // 
            this.CBEstado.AutoSize = true;
            this.CBEstado.Location = new System.Drawing.Point(156, 188);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(78, 24);
            this.CBEstado.TabIndex = 29;
            this.CBEstado.Text = "Activo";
            this.CBEstado.UseVisualStyleBackColor = true;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(156, 317);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(314, 26);
            this.TxtTotal.TabIndex = 28;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(156, 271);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(314, 26);
            this.TxtDescuento.TabIndex = 27;
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(156, 223);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(314, 26);
            this.TxtSubTotal.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Sub-Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Estado:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(833, 287);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(117, 50);
            this.BtnEliminar.TabIndex = 32;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(697, 287);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(117, 50);
            this.BtnModificar.TabIndex = 31;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(557, 287);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(117, 50);
            this.BtnGuardar.TabIndex = 30;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // DGVFactura
            // 
            this.DGVFactura.AllowUserToDeleteRows = false;
            this.DGVFactura.AutoGenerateColumns = false;
            this.DGVFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facturaIdDataGridViewTextBoxColumn,
            this.clienteIdDataGridViewTextBoxColumn,
            this.pedidoIdDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaFacturaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn});
            this.DGVFactura.DataSource = this.facturasBindingSource;
            this.DGVFactura.Location = new System.Drawing.Point(12, 395);
            this.DGVFactura.Name = "DGVFactura";
            this.DGVFactura.ReadOnly = true;
            this.DGVFactura.RowHeadersWidth = 62;
            this.DGVFactura.RowTemplate.Height = 28;
            this.DGVFactura.Size = new System.Drawing.Size(1051, 236);
            this.DGVFactura.TabIndex = 33;
            // 
            // proyectoRadDataSet6
            // 
            this.proyectoRadDataSet6.DataSetName = "ProyectoRadDataSet6";
            this.proyectoRadDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "Facturas";
            this.facturasBindingSource.DataSource = this.proyectoRadDataSet6;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // facturaIdDataGridViewTextBoxColumn
            // 
            this.facturaIdDataGridViewTextBoxColumn.DataPropertyName = "FacturaId";
            this.facturaIdDataGridViewTextBoxColumn.HeaderText = "FacturaId";
            this.facturaIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.facturaIdDataGridViewTextBoxColumn.Name = "facturaIdDataGridViewTextBoxColumn";
            this.facturaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.facturaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pedidoIdDataGridViewTextBoxColumn
            // 
            this.pedidoIdDataGridViewTextBoxColumn.DataPropertyName = "PedidoId";
            this.pedidoIdDataGridViewTextBoxColumn.HeaderText = "PedidoId";
            this.pedidoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pedidoIdDataGridViewTextBoxColumn.Name = "pedidoIdDataGridViewTextBoxColumn";
            this.pedidoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedidoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaFacturaDataGridViewTextBoxColumn
            // 
            this.fechaFacturaDataGridViewTextBoxColumn.DataPropertyName = "FechaFactura";
            this.fechaFacturaDataGridViewTextBoxColumn.HeaderText = "FechaFactura";
            this.fechaFacturaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaFacturaDataGridViewTextBoxColumn.Name = "fechaFacturaDataGridViewTextBoxColumn";
            this.fechaFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaFacturaDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subtotalDataGridViewTextBoxColumn.Width = 150;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descuentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(156, 61);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(314, 26);
            this.TXTID.TabIndex = 34;
            // 
            // CBXClienteId
            // 
            this.CBXClienteId.FormattingEnabled = true;
            this.CBXClienteId.Location = new System.Drawing.Point(156, 102);
            this.CBXClienteId.Name = "CBXClienteId";
            this.CBXClienteId.Size = new System.Drawing.Size(314, 28);
            this.CBXClienteId.TabIndex = 35;
            // 
            // CBXPedidoId
            // 
            this.CBXPedidoId.FormattingEnabled = true;
            this.CBXPedidoId.Location = new System.Drawing.Point(156, 145);
            this.CBXPedidoId.Name = "CBXPedidoId";
            this.CBXPedidoId.Size = new System.Drawing.Size(314, 28);
            this.CBXPedidoId.TabIndex = 36;
            // 
            // PFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 643);
            this.Controls.Add(this.CBXPedidoId);
            this.Controls.Add(this.CBXClienteId);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.DGVFactura);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.TxtSubTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DTFechaFactura);
            this.Controls.Add(this.DTFechaCreación);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PFactura";
            this.Text = "PFactura";
            this.Load += new System.EventHandler(this.PFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTFechaFactura;
        private System.Windows.Forms.DateTimePicker DTFechaCreación;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CBEstado;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DGVFactura;
        private ProyectoRadDataSet6 proyectoRadDataSet6;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private ProyectoRadDataSet6TableAdapters.FacturasTableAdapter facturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.ComboBox CBXClienteId;
        private System.Windows.Forms.ComboBox CBXPedidoId;
    }
}