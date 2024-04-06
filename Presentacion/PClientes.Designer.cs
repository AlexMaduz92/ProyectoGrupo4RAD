namespace Presentacion
{
    partial class PClientes
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
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.CBEstado = new System.Windows.Forms.CheckBox();
            this.DTFCreacion = new System.Windows.Forms.DateTimePicker();
            this.CBXGDescuento = new System.Windows.Forms.ComboBox();
            this.CBXCPago = new System.Windows.Forms.ComboBox();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.proyectoRadDataSet2 = new Presentacion.ProyectoRadDataSet2();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Presentacion.ProyectoRadDataSet2TableAdapters.ClientesTableAdapter();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Grupo de descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(608, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Condicion de pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de creación:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(110, 70);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(320, 26);
            this.TxtID.TabIndex = 9;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(110, 112);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(320, 26);
            this.TxtCodigo.TabIndex = 10;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(110, 165);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(320, 26);
            this.TxtNombre.TabIndex = 11;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(110, 217);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(320, 26);
            this.TxtApellido.TabIndex = 12;
            // 
            // CBEstado
            // 
            this.CBEstado.AutoSize = true;
            this.CBEstado.Location = new System.Drawing.Point(816, 167);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(78, 24);
            this.CBEstado.TabIndex = 15;
            this.CBEstado.Text = "Activo";
            this.CBEstado.UseVisualStyleBackColor = true;
            // 
            // DTFCreacion
            // 
            this.DTFCreacion.Location = new System.Drawing.Point(816, 217);
            this.DTFCreacion.Name = "DTFCreacion";
            this.DTFCreacion.Size = new System.Drawing.Size(303, 26);
            this.DTFCreacion.TabIndex = 16;
            // 
            // CBXGDescuento
            // 
            this.CBXGDescuento.FormattingEnabled = true;
            this.CBXGDescuento.Location = new System.Drawing.Point(816, 62);
            this.CBXGDescuento.Name = "CBXGDescuento";
            this.CBXGDescuento.Size = new System.Drawing.Size(296, 28);
            this.CBXGDescuento.TabIndex = 17;
            // 
            // CBXCPago
            // 
            this.CBXCPago.FormattingEnabled = true;
            this.CBXCPago.Location = new System.Drawing.Point(816, 112);
            this.CBXCPago.Name = "CBXCPago";
            this.CBXCPago.Size = new System.Drawing.Size(296, 28);
            this.CBXCPago.TabIndex = 18;
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToDeleteRows = false;
            this.DGVClientes.AutoGenerateColumns = false;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIdDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn,
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn});
            this.DGVClientes.DataSource = this.clientesBindingSource;
            this.DGVClientes.Location = new System.Drawing.Point(12, 354);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.RowHeadersWidth = 62;
            this.DGVClientes.RowTemplate.Height = 28;
            this.DGVClientes.Size = new System.Drawing.Size(1282, 150);
            this.DGVClientes.TabIndex = 19;
            // 
            // proyectoRadDataSet2
            // 
            this.proyectoRadDataSet2.DataSetName = "ProyectoRadDataSet2";
            this.proyectoRadDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.proyectoRadDataSet2;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
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
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.Width = 150;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // condicionPagoCondicionPagoIdDataGridViewTextBoxColumn
            // 
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.DataPropertyName = "CondicionPago_CondicionPagoId";
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.HeaderText = "CondicionPago_CondicionPagoId";
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.Name = "condicionPagoCondicionPagoIdDataGridViewTextBoxColumn";
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn
            // 
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.DataPropertyName = "GrupoDescuento_GrupoDescuentoId";
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.HeaderText = "GrupoDescuento_GrupoDescuentoId";
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.Name = "grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn";
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 150;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(889, 272);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(117, 50);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(753, 272);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(117, 50);
            this.BtnModificar.TabIndex = 21;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(613, 272);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(117, 50);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // PClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 539);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.CBXCPago);
            this.Controls.Add(this.CBXGDescuento);
            this.Controls.Add(this.DTFCreacion);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PClientes";
            this.Text = "PClientes";
            this.Load += new System.EventHandler(this.PClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.CheckBox CBEstado;
        private System.Windows.Forms.DateTimePicker DTFCreacion;
        private System.Windows.Forms.ComboBox CBXGDescuento;
        private System.Windows.Forms.ComboBox CBXCPago;
        private System.Windows.Forms.DataGridView DGVClientes;
        private ProyectoRadDataSet2 proyectoRadDataSet2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ProyectoRadDataSet2TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionPagoCondicionPagoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}