namespace Presentacion
{
    partial class PCondicionesPago
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
            this.DGVCPago = new System.Windows.Forms.DataGridView();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condiccionPagoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRadDataSet4 = new Presentacion.ProyectoRadDataSet4();
            this.condiccionPagoesTableAdapter = new Presentacion.ProyectoRadDataSet4TableAdapters.CondiccionPagoesTableAdapter();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTCodigo = new System.Windows.Forms.TextBox();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.CBEstado = new System.Windows.Forms.CheckBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.DTFCreacion = new System.Windows.Forms.DateTimePicker();
            this.label = new System.Windows.Forms.Label();
            this.CBXFiltro = new System.Windows.Forms.ComboBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.proyectoRadDataSet12 = new Presentacion.ProyectoRadDataSet12();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionPagoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condiccionPagoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONDICIONES DE PAGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de creación:";
            // 
            // DGVCPago
            // 
            this.DGVCPago.AllowUserToDeleteRows = false;
            this.DGVCPago.AutoGenerateColumns = false;
            this.DGVCPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estadoDataGridViewCheckBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.condicionPagoIdDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.diasDataGridViewTextBoxColumn});
            this.DGVCPago.DataSource = this.condiccionPagoesBindingSource;
            this.DGVCPago.Location = new System.Drawing.Point(8, 162);
            this.DGVCPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGVCPago.Name = "DGVCPago";
            this.DGVCPago.ReadOnly = true;
            this.DGVCPago.RowHeadersWidth = 62;
            this.DGVCPago.RowTemplate.Height = 28;
            this.DGVCPago.Size = new System.Drawing.Size(943, 157);
            this.DGVCPago.TabIndex = 7;
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
            // condiccionPagoesBindingSource
            // 
            this.condiccionPagoesBindingSource.DataMember = "CondiccionPagoes";
            this.condiccionPagoesBindingSource.DataSource = this.proyectoRadDataSet4;
            // 
            // proyectoRadDataSet4
            // 
            this.proyectoRadDataSet4.DataSetName = "ProyectoRadDataSet4";
            this.proyectoRadDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // condiccionPagoesTableAdapter
            // 
            this.condiccionPagoesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(826, 116);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(78, 32);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(735, 116);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(78, 32);
            this.BtnModificar.TabIndex = 24;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(642, 116);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(78, 32);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(155, 43);
            this.TXTID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(197, 20);
            this.TXTID.TabIndex = 26;
            // 
            // TXTCodigo
            // 
            this.TXTCodigo.Location = new System.Drawing.Point(155, 68);
            this.TXTCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTCodigo.Name = "TXTCodigo";
            this.TXTCodigo.Size = new System.Drawing.Size(197, 20);
            this.TXTCodigo.TabIndex = 27;
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.Location = new System.Drawing.Point(155, 97);
            this.TXTDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(197, 20);
            this.TXTDescripcion.TabIndex = 28;
            // 
            // CBEstado
            // 
            this.CBEstado.AutoSize = true;
            this.CBEstado.Location = new System.Drawing.Point(155, 132);
            this.CBEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(63, 21);
            this.CBEstado.TabIndex = 29;
            this.CBEstado.Text = "Activo";
            this.CBEstado.UseVisualStyleBackColor = true;
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(700, 40);
            this.TxtDias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(205, 20);
            this.TxtDias.TabIndex = 30;
            // 
            // DTFCreacion
            // 
            this.DTFCreacion.Location = new System.Drawing.Point(700, 66);
            this.DTFCreacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTFCreacion.Name = "DTFCreacion";
            this.DTFCreacion.Size = new System.Drawing.Size(205, 20);
            this.DTFCreacion.TabIndex = 31;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(271, 124);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(247, 37);
            this.label.TabIndex = 64;
            this.label.Text = "Filtro de estado:";
            // 
            // CBXFiltro
            // 
            this.CBXFiltro.FormattingEnabled = true;
            this.CBXFiltro.Location = new System.Drawing.Point(449, 130);
            this.CBXFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBXFiltro.Name = "CBXFiltro";
            this.CBXFiltro.Size = new System.Drawing.Size(119, 21);
            this.CBXFiltro.TabIndex = 63;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(930, -1);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(27, 21);
            this.BtnCerrar.TabIndex = 62;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // proyectoRadDataSet12
            // 
            this.proyectoRadDataSet12.DataSetName = "ProyectoRadDataSet12";
            this.proyectoRadDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "Dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "Dias";
            this.diasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            this.diasDataGridViewTextBoxColumn.ReadOnly = true;
            this.diasDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
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
            // condicionPagoIdDataGridViewTextBoxColumn
            // 
            this.condicionPagoIdDataGridViewTextBoxColumn.DataPropertyName = "CondicionPagoId";
            this.condicionPagoIdDataGridViewTextBoxColumn.HeaderText = "CondicionPagoId";
            this.condicionPagoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.condicionPagoIdDataGridViewTextBoxColumn.Name = "condicionPagoIdDataGridViewTextBoxColumn";
            this.condicionPagoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.condicionPagoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // PCondicionesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(957, 326);
            this.Controls.Add(this.label);
            this.Controls.Add(this.CBXFiltro);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DTFCreacion);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TXTDescripcion);
            this.Controls.Add(this.TXTCodigo);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DGVCPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PCondicionesPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PCondicionesPago";
            this.Load += new System.EventHandler(this.PCondicionesPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condiccionPagoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet12)).EndInit();
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
        private System.Windows.Forms.DataGridView DGVCPago;
        private ProyectoRadDataSet4 proyectoRadDataSet4;
        private System.Windows.Forms.BindingSource condiccionPagoesBindingSource;
        private ProyectoRadDataSet4TableAdapters.CondiccionPagoesTableAdapter condiccionPagoesTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTCodigo;
        private System.Windows.Forms.TextBox TXTDescripcion;
        private System.Windows.Forms.CheckBox CBEstado;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.DateTimePicker DTFCreacion;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox CBXFiltro;
        private System.Windows.Forms.Button BtnCerrar;
        private ProyectoRadDataSet12 proyectoRadDataSet12;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionPagoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
    }
}