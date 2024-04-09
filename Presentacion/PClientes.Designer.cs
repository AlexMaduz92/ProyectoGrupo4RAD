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
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRadDataSet2 = new Presentacion.ProyectoRadDataSet2();
            this.clientesTableAdapter = new Presentacion.ProyectoRadDataSet2TableAdapters.ClientesTableAdapter();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Grupo de descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Condicion de pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de creación:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(73, 46);
            this.TxtID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(215, 20);
            this.TxtID.TabIndex = 9;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(73, 73);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(215, 20);
            this.TxtCodigo.TabIndex = 10;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(73, 107);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(215, 20);
            this.TxtNombre.TabIndex = 11;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(73, 141);
            this.TxtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(215, 20);
            this.TxtApellido.TabIndex = 12;
            // 
            // CBEstado
            // 
            this.CBEstado.AutoSize = true;
            this.CBEstado.Location = new System.Drawing.Point(544, 109);
            this.CBEstado.Margin = new System.Windows.Forms.Padding(2);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(56, 17);
            this.CBEstado.TabIndex = 15;
            this.CBEstado.Text = "Activo";
            this.CBEstado.UseVisualStyleBackColor = true;
            // 
            // DTFCreacion
            // 
            this.DTFCreacion.Location = new System.Drawing.Point(544, 141);
            this.DTFCreacion.Margin = new System.Windows.Forms.Padding(2);
            this.DTFCreacion.Name = "DTFCreacion";
            this.DTFCreacion.Size = new System.Drawing.Size(203, 20);
            this.DTFCreacion.TabIndex = 16;
            // 
            // CBXGDescuento
            // 
            this.CBXGDescuento.FormattingEnabled = true;
            this.CBXGDescuento.Location = new System.Drawing.Point(544, 40);
            this.CBXGDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.CBXGDescuento.Name = "CBXGDescuento";
            this.CBXGDescuento.Size = new System.Drawing.Size(199, 21);
            this.CBXGDescuento.TabIndex = 17;
            // 
            // CBXCPago
            // 
            this.CBXCPago.FormattingEnabled = true;
            this.CBXCPago.Location = new System.Drawing.Point(544, 73);
            this.CBXCPago.Margin = new System.Windows.Forms.Padding(2);
            this.CBXCPago.Name = "CBXCPago";
            this.CBXCPago.Size = new System.Drawing.Size(199, 21);
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
            this.DGVClientes.Location = new System.Drawing.Point(11, 228);
            this.DGVClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.RowHeadersWidth = 62;
            this.DGVClientes.RowTemplate.Height = 28;
            this.DGVClientes.Size = new System.Drawing.Size(855, 98);
            this.DGVClientes.TabIndex = 19;
            this.DGVClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClientes_CellContentDoubleClick);
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
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombresDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidosDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadoDataGridViewCheckBoxColumn.Width = 150;
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
            // condicionPagoCondicionPagoIdDataGridViewTextBoxColumn
            // 
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.DataPropertyName = "CondicionPago_CondicionPagoId";
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.HeaderText = "CondicionPago_CondicionPagoId";
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.Name = "condicionPagoCondicionPagoIdDataGridViewTextBoxColumn";
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.condicionPagoCondicionPagoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn
            // 
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.DataPropertyName = "GrupoDescuento_GrupoDescuentoId";
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.HeaderText = "GrupoDescuento_GrupoDescuentoId";
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.Name = "grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn";
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupoDescuentoGrupoDescuentoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.proyectoRadDataSet2;
            // 
            // proyectoRadDataSet2
            // 
            this.proyectoRadDataSet2.DataSetName = "ProyectoRadDataSet2";
            this.proyectoRadDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(593, 177);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(78, 32);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(502, 177);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(78, 32);
            this.BtnModificar.TabIndex = 21;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(409, 177);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(78, 32);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(687, 177);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(78, 32);
            this.BtnLimpiar.TabIndex = 23;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 350);
            this.Controls.Add(this.BtnLimpiar);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PClientes";
            this.Load += new System.EventHandler(this.PClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}