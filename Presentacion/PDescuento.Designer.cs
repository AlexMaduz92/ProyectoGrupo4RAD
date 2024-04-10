namespace Presentacion
{
    partial class PDescuento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


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
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.CBEstado = new System.Windows.Forms.CheckBox();
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.DTFCreacion = new System.Windows.Forms.DateTimePicker();
            this.DGVDescuento = new System.Windows.Forms.DataGridView();
            this.grupoDescuentoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoDescuentoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRadDataSet1 = new Presentacion.ProyectoRadDataSet1();
            this.grupoDescuentoesTableAdapter = new Presentacion.ProyectoRadDataSet1TableAdapters.GrupoDescuentoesTableAdapter();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoDescuentoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(829, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCUENTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(858, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Porcentaje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(858, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha de creación:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(281, 74);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(349, 31);
            this.TxtID.TabIndex = 7;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(281, 120);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(349, 31);
            this.TxtCodigo.TabIndex = 8;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(281, 176);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(349, 31);
            this.TxtDescripcion.TabIndex = 9;
            // 
            // CBEstado
            // 
            this.CBEstado.AutoSize = true;
            this.CBEstado.Location = new System.Drawing.Point(281, 245);
            this.CBEstado.Margin = new System.Windows.Forms.Padding(4);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(97, 29);
            this.CBEstado.TabIndex = 10;
            this.CBEstado.Text = "Activo";
            this.CBEstado.UseVisualStyleBackColor = true;
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.Location = new System.Drawing.Point(1243, 70);
            this.TxtPorcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(395, 31);
            this.TxtPorcentaje.TabIndex = 11;
            // 
            // DTFCreacion
            // 
            this.DTFCreacion.Location = new System.Drawing.Point(1242, 122);
            this.DTFCreacion.Margin = new System.Windows.Forms.Padding(4);
            this.DTFCreacion.Name = "DTFCreacion";
            this.DTFCreacion.Size = new System.Drawing.Size(396, 31);
            this.DTFCreacion.TabIndex = 12;
            // 
            // DGVDescuento
            // 
            this.DGVDescuento.AllowUserToDeleteRows = false;
            this.DGVDescuento.AutoGenerateColumns = false;
            this.DGVDescuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDescuento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupoDescuentoIdDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.porcentajeDataGridViewTextBoxColumn});
            this.DGVDescuento.DataSource = this.grupoDescuentoesBindingSource;
            this.DGVDescuento.Location = new System.Drawing.Point(16, 320);
            this.DGVDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.DGVDescuento.Name = "DGVDescuento";
            this.DGVDescuento.ReadOnly = true;
            this.DGVDescuento.RowHeadersWidth = 62;
            this.DGVDescuento.RowTemplate.Height = 28;
            this.DGVDescuento.Size = new System.Drawing.Size(1926, 394);
            this.DGVDescuento.TabIndex = 13;
            // 
            // grupoDescuentoIdDataGridViewTextBoxColumn
            // 
            this.grupoDescuentoIdDataGridViewTextBoxColumn.DataPropertyName = "GrupoDescuentoId";
            this.grupoDescuentoIdDataGridViewTextBoxColumn.HeaderText = "GrupoDescuentoId";
            this.grupoDescuentoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.grupoDescuentoIdDataGridViewTextBoxColumn.Name = "grupoDescuentoIdDataGridViewTextBoxColumn";
            this.grupoDescuentoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupoDescuentoIdDataGridViewTextBoxColumn.Width = 150;
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
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
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
            // porcentajeDataGridViewTextBoxColumn
            // 
            this.porcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje";
            this.porcentajeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.porcentajeDataGridViewTextBoxColumn.Name = "porcentajeDataGridViewTextBoxColumn";
            this.porcentajeDataGridViewTextBoxColumn.ReadOnly = true;
            this.porcentajeDataGridViewTextBoxColumn.Width = 150;
            // 
            // grupoDescuentoesBindingSource
            // 
            this.grupoDescuentoesBindingSource.DataMember = "GrupoDescuentoes";
            this.grupoDescuentoesBindingSource.DataSource = this.proyectoRadDataSet1;
            // 
            // proyectoRadDataSet1
            // 
            this.proyectoRadDataSet1.DataSetName = "ProyectoRadDataSet1";
            this.proyectoRadDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupoDescuentoesTableAdapter
            // 
            this.grupoDescuentoesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(1222, 212);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(156, 62);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(1041, 212);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(156, 62);
            this.BtnModificar.TabIndex = 17;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(854, 212);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(156, 62);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // PDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1955, 727);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DGVDescuento);
            this.Controls.Add(this.DTFCreacion);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PDescuento";
            this.Load += new System.EventHandler(this.PDescuento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoDescuentoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet1)).EndInit();
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
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.CheckBox CBEstado;
        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.DateTimePicker DTFCreacion;
        private System.Windows.Forms.DataGridView DGVDescuento;
        private ProyectoRadDataSet1 proyectoRadDataSet1;
        private System.Windows.Forms.BindingSource grupoDescuentoesBindingSource;
        private ProyectoRadDataSet1TableAdapters.GrupoDescuentoesTableAdapter grupoDescuentoesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoDescuentoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}