namespace Presentacion
{
    partial class PPEdidos
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DGVPedidos = new System.Windows.Forms.DataGridView();
            this.proyectoRadDataSet5 = new Presentacion.ProyectoRadDataSet5();
            this.pedidoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoesTableAdapter = new Presentacion.ProyectoRadDataSet5TableAdapters.PedidoesTableAdapter();
            this.pedidoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.CBXCodCliente = new System.Windows.Forms.ComboBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.DTFechaCreación = new System.Windows.Forms.DateTimePicker();
            this.DTFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.CBEstado = new System.Windows.Forms.CheckBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de creación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de pedido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sub-Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descuento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total:";
            // 
            // DGVPedidos
            // 
            this.DGVPedidos.AutoGenerateColumns = false;
            this.DGVPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pedidoIdDataGridViewTextBoxColumn,
            this.clienteIdDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.fechaPedidoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.descuentoDataGridViewTextBoxColumn});
            this.DGVPedidos.DataSource = this.pedidoesBindingSource;
            this.DGVPedidos.Location = new System.Drawing.Point(16, 314);
            this.DGVPedidos.Name = "DGVPedidos";
            this.DGVPedidos.RowHeadersWidth = 62;
            this.DGVPedidos.RowTemplate.Height = 28;
            this.DGVPedidos.Size = new System.Drawing.Size(1072, 150);
            this.DGVPedidos.TabIndex = 9;
            // 
            // proyectoRadDataSet5
            // 
            this.proyectoRadDataSet5.DataSetName = "ProyectoRadDataSet5";
            this.proyectoRadDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoesBindingSource
            // 
            this.pedidoesBindingSource.DataMember = "Pedidoes";
            this.pedidoesBindingSource.DataSource = this.proyectoRadDataSet5;
            // 
            // pedidoesTableAdapter
            // 
            this.pedidoesTableAdapter.ClearBeforeFill = true;
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
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaPedidoDataGridViewTextBoxColumn
            // 
            this.fechaPedidoDataGridViewTextBoxColumn.DataPropertyName = "FechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.HeaderText = "FechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaPedidoDataGridViewTextBoxColumn.Name = "fechaPedidoDataGridViewTextBoxColumn";
            this.fechaPedidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.Width = 150;
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "Descuento";
            this.descuentoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(153, 53);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(314, 26);
            this.TxtID.TabIndex = 11;
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(153, 175);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(314, 26);
            this.TxtSubTotal.TabIndex = 12;
            // 
            // CBXCodCliente
            // 
            this.CBXCodCliente.FormattingEnabled = true;
            this.CBXCodCliente.Location = new System.Drawing.Point(153, 96);
            this.CBXCodCliente.Name = "CBXCodCliente";
            this.CBXCodCliente.Size = new System.Drawing.Size(314, 28);
            this.CBXCodCliente.TabIndex = 13;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(153, 223);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(314, 26);
            this.TxtDescuento.TabIndex = 14;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(153, 269);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(314, 26);
            this.TxtTotal.TabIndex = 15;
            // 
            // DTFechaCreación
            // 
            this.DTFechaCreación.Location = new System.Drawing.Point(707, 53);
            this.DTFechaCreación.Name = "DTFechaCreación";
            this.DTFechaCreación.Size = new System.Drawing.Size(322, 26);
            this.DTFechaCreación.TabIndex = 16;
            // 
            // DTFechaPedido
            // 
            this.DTFechaPedido.Location = new System.Drawing.Point(707, 99);
            this.DTFechaPedido.Name = "DTFechaPedido";
            this.DTFechaPedido.Size = new System.Drawing.Size(322, 26);
            this.DTFechaPedido.TabIndex = 17;
            // 
            // CBEstado
            // 
            this.CBEstado.AutoSize = true;
            this.CBEstado.Location = new System.Drawing.Point(153, 140);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(78, 24);
            this.CBEstado.TabIndex = 18;
            this.CBEstado.Text = "Activo";
            this.CBEstado.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(814, 245);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(117, 50);
            this.BtnEliminar.TabIndex = 28;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(678, 245);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(117, 50);
            this.BtnModificar.TabIndex = 27;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(538, 245);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(117, 50);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // PPEdidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 490);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.DTFechaPedido);
            this.Controls.Add(this.DTFechaCreación);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.CBXCodCliente);
            this.Controls.Add(this.TxtSubTotal);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.DGVPedidos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PPEdidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PPEdidos";
            this.Load += new System.EventHandler(this.PPEdidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGVPedidos;
        private ProyectoRadDataSet5 proyectoRadDataSet5;
        private System.Windows.Forms.BindingSource pedidoesBindingSource;
        private ProyectoRadDataSet5TableAdapters.PedidoesTableAdapter pedidoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedidoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.ComboBox CBXCodCliente;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DateTimePicker DTFechaCreación;
        private System.Windows.Forms.DateTimePicker DTFechaPedido;
        private System.Windows.Forms.CheckBox CBEstado;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}