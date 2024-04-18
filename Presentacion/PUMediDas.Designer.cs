namespace Presentacion
{
    partial class PUMediDas
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
            this.label = new System.Windows.Forms.Label();
            this.CBXFiltro = new System.Windows.Forms.ComboBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnElimina = new System.Windows.Forms.Button();
            this.BtnModifica = new System.Windows.Forms.Button();
            this.BtnGuarda = new System.Windows.Forms.Button();
            this.unidadMedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRadDataSet17 = new Presentacion.ProyectoRadDataSet17();
            this.DTFcreaciones = new System.Windows.Forms.DateTimePicker();
            this.CBEstados = new System.Windows.Forms.CheckBox();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.Txtcodig = new System.Windows.Forms.TextBox();
            this.TXTIDS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.unidadMedidasTableAdapter = new Presentacion.ProyectoRadDataSet17TableAdapters.UnidadMedidasTableAdapter();
            this.DGVMEDIDA = new System.Windows.Forms.DataGridView();
            this.proyectoRadDataSet19 = new Presentacion.ProyectoRadDataSet19();
            this.unidadMedidasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unidadMedidasTableAdapter1 = new Presentacion.ProyectoRadDataSet19TableAdapters.UnidadMedidasTableAdapter();
            this.unidadMedidaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMEDIDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(13, 190);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(167, 26);
            this.label.TabIndex = 90;
            this.label.Text = "Filtro de estado:";
            // 
            // CBXFiltro
            // 
            this.CBXFiltro.FormattingEnabled = true;
            this.CBXFiltro.Location = new System.Drawing.Point(191, 196);
            this.CBXFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.CBXFiltro.Name = "CBXFiltro";
            this.CBXFiltro.Size = new System.Drawing.Size(115, 21);
            this.CBXFiltro.TabIndex = 89;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(555, -2);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(27, 21);
            this.BtnCerrar.TabIndex = 88;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnElimina
            // 
            this.BtnElimina.Location = new System.Drawing.Point(492, 193);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(69, 37);
            this.BtnElimina.TabIndex = 87;
            this.BtnElimina.Text = "Eliminar";
            this.BtnElimina.UseVisualStyleBackColor = true;
            // 
            // BtnModifica
            // 
            this.BtnModifica.Location = new System.Drawing.Point(412, 193);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(74, 38);
            this.BtnModifica.TabIndex = 86;
            this.BtnModifica.Text = "Modificar";
            this.BtnModifica.UseVisualStyleBackColor = true;
            // 
            // BtnGuarda
            // 
            this.BtnGuarda.Location = new System.Drawing.Point(323, 193);
            this.BtnGuarda.Name = "BtnGuarda";
            this.BtnGuarda.Size = new System.Drawing.Size(74, 37);
            this.BtnGuarda.TabIndex = 85;
            this.BtnGuarda.Text = "Guardar";
            this.BtnGuarda.UseVisualStyleBackColor = true;
            // 
            // unidadMedidasBindingSource
            // 
            this.unidadMedidasBindingSource.DataMember = "UnidadMedidas";
            this.unidadMedidasBindingSource.DataSource = this.proyectoRadDataSet17;
            // 
            // proyectoRadDataSet17
            // 
            this.proyectoRadDataSet17.DataSetName = "ProyectoRadDataSet17";
            this.proyectoRadDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTFcreaciones
            // 
            this.DTFcreaciones.Location = new System.Drawing.Point(217, 121);
            this.DTFcreaciones.Name = "DTFcreaciones";
            this.DTFcreaciones.Size = new System.Drawing.Size(224, 20);
            this.DTFcreaciones.TabIndex = 83;
            // 
            // CBEstados
            // 
            this.CBEstados.AutoSize = true;
            this.CBEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstados.Location = new System.Drawing.Point(104, 153);
            this.CBEstados.Name = "CBEstados";
            this.CBEstados.Size = new System.Drawing.Size(90, 29);
            this.CBEstados.TabIndex = 82;
            this.CBEstados.Text = "Activo";
            this.CBEstados.UseVisualStyleBackColor = true;
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.Location = new System.Drawing.Point(469, 86);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(92, 20);
            this.TxtDescrip.TabIndex = 81;
            // 
            // Txtcodig
            // 
            this.Txtcodig.Location = new System.Drawing.Point(102, 86);
            this.Txtcodig.Name = "Txtcodig";
            this.Txtcodig.Size = new System.Drawing.Size(224, 20);
            this.Txtcodig.TabIndex = 80;
            // 
            // TXTIDS
            // 
            this.TXTIDS.Enabled = false;
            this.TXTIDS.Location = new System.Drawing.Point(55, 49);
            this.TXTIDS.Name = "TXTIDS";
            this.TXTIDS.Size = new System.Drawing.Size(114, 20);
            this.TXTIDS.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 25);
            this.label12.TabIndex = 78;
            this.label12.Text = "Fecha de creación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 77;
            this.label11.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(341, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 76;
            this.label10.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 75;
            this.label9.Text = "Codigo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 31);
            this.label7.TabIndex = 73;
            this.label7.Text = "UNIDAD DE MEDIDA";
            // 
            // unidadMedidasTableAdapter
            // 
            this.unidadMedidasTableAdapter.ClearBeforeFill = true;
            // 
            // DGVMEDIDA
            // 
            this.DGVMEDIDA.AllowUserToDeleteRows = false;
            this.DGVMEDIDA.AutoGenerateColumns = false;
            this.DGVMEDIDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMEDIDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unidadMedidaIdDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn});
            this.DGVMEDIDA.DataSource = this.unidadMedidasBindingSource1;
            this.DGVMEDIDA.Location = new System.Drawing.Point(18, 243);
            this.DGVMEDIDA.Name = "DGVMEDIDA";
            this.DGVMEDIDA.ReadOnly = true;
            this.DGVMEDIDA.Size = new System.Drawing.Size(551, 150);
            this.DGVMEDIDA.TabIndex = 91;
            // 
            // proyectoRadDataSet19
            // 
            this.proyectoRadDataSet19.DataSetName = "ProyectoRadDataSet19";
            this.proyectoRadDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadMedidasBindingSource1
            // 
            this.unidadMedidasBindingSource1.DataMember = "UnidadMedidas";
            this.unidadMedidasBindingSource1.DataSource = this.proyectoRadDataSet19;
            // 
            // unidadMedidasTableAdapter1
            // 
            this.unidadMedidasTableAdapter1.ClearBeforeFill = true;
            // 
            // unidadMedidaIdDataGridViewTextBoxColumn
            // 
            this.unidadMedidaIdDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedidaId";
            this.unidadMedidaIdDataGridViewTextBoxColumn.HeaderText = "UnidadMedidaId";
            this.unidadMedidaIdDataGridViewTextBoxColumn.Name = "unidadMedidaIdDataGridViewTextBoxColumn";
            this.unidadMedidaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PUMediDas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(581, 405);
            this.Controls.Add(this.DGVMEDIDA);
            this.Controls.Add(this.label);
            this.Controls.Add(this.CBXFiltro);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnElimina);
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.BtnGuarda);
            this.Controls.Add(this.DTFcreaciones);
            this.Controls.Add(this.CBEstados);
            this.Controls.Add(this.TxtDescrip);
            this.Controls.Add(this.Txtcodig);
            this.Controls.Add(this.TXTIDS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PUMediDas";
            this.Text = "PUMediDas";
            this.Load += new System.EventHandler(this.PUMediDas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMEDIDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedidasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox CBXFiltro;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnElimina;
        private System.Windows.Forms.Button BtnModifica;
        private System.Windows.Forms.Button BtnGuarda;
        private System.Windows.Forms.DateTimePicker DTFcreaciones;
        private System.Windows.Forms.CheckBox CBEstados;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.TextBox Txtcodig;
        private System.Windows.Forms.TextBox TXTIDS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private ProyectoRadDataSet17 proyectoRadDataSet17;
        private System.Windows.Forms.BindingSource unidadMedidasBindingSource;
        private ProyectoRadDataSet17TableAdapters.UnidadMedidasTableAdapter unidadMedidasTableAdapter;
        private System.Windows.Forms.DataGridView DGVMEDIDA;
        private ProyectoRadDataSet19 proyectoRadDataSet19;
        private System.Windows.Forms.BindingSource unidadMedidasBindingSource1;
        private ProyectoRadDataSet19TableAdapters.UnidadMedidasTableAdapter unidadMedidasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
    }
}