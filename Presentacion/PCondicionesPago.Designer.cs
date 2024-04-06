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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proyectoRadDataSet4 = new Presentacion.ProyectoRadDataSet4();
            this.condiccionPagoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condiccionPagoesTableAdapter = new Presentacion.ProyectoRadDataSet4TableAdapters.CondiccionPagoesTableAdapter();
            this.condicionPagoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTCodigo = new System.Windows.Forms.TextBox();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.CBEstado = new System.Windows.Forms.CheckBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.DTFCreacion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condiccionPagoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONDICIONES DE PAGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de creación:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.condicionPagoIdDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.diasDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.condiccionPagoesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // proyectoRadDataSet4
            // 
            this.proyectoRadDataSet4.DataSetName = "ProyectoRadDataSet4";
            this.proyectoRadDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // condiccionPagoesBindingSource
            // 
            this.condiccionPagoesBindingSource.DataMember = "CondiccionPagoes";
            this.condiccionPagoesBindingSource.DataSource = this.proyectoRadDataSet4;
            // 
            // condiccionPagoesTableAdapter
            // 
            this.condiccionPagoesTableAdapter.ClearBeforeFill = true;
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
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "Dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "Dias";
            this.diasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            this.diasDataGridViewTextBoxColumn.Width = 150;
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
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(818, 173);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(117, 50);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(682, 173);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(117, 50);
            this.BtnModificar.TabIndex = 24;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(542, 173);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(117, 50);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(141, 58);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(293, 26);
            this.TXTID.TabIndex = 26;
            // 
            // TXTCodigo
            // 
            this.TXTCodigo.Location = new System.Drawing.Point(141, 97);
            this.TXTCodigo.Name = "TXTCodigo";
            this.TXTCodigo.Size = new System.Drawing.Size(293, 26);
            this.TXTCodigo.TabIndex = 27;
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.Location = new System.Drawing.Point(141, 141);
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(293, 26);
            this.TXTDescripcion.TabIndex = 28;
            // 
            // CBEstado
            // 
            this.CBEstado.AutoSize = true;
            this.CBEstado.Location = new System.Drawing.Point(141, 187);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(78, 24);
            this.CBEstado.TabIndex = 29;
            this.CBEstado.Text = "Activo";
            this.CBEstado.UseVisualStyleBackColor = true;
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(687, 55);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(306, 26);
            this.TxtDias.TabIndex = 30;
            // 
            // DTFCreacion
            // 
            this.DTFCreacion.Location = new System.Drawing.Point(687, 95);
            this.DTFCreacion.Name = "DTFCreacion";
            this.DTFCreacion.Size = new System.Drawing.Size(306, 26);
            this.DTFCreacion.TabIndex = 31;
            // 
            // PCondicionesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 413);
            this.Controls.Add(this.DTFCreacion);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TXTDescripcion);
            this.Controls.Add(this.TXTCodigo);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PCondicionesPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PCondicionesPago";
            this.Load += new System.EventHandler(this.PCondicionesPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condiccionPagoesBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoRadDataSet4 proyectoRadDataSet4;
        private System.Windows.Forms.BindingSource condiccionPagoesBindingSource;
        private ProyectoRadDataSet4TableAdapters.CondiccionPagoesTableAdapter condiccionPagoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionPagoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
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
    }
}