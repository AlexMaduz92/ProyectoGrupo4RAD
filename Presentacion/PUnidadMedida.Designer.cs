namespace Negocio
{
    partial class PUnidadMedida
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTIDS = new System.Windows.Forms.TextBox();
            this.Txtcodig = new System.Windows.Forms.TextBox();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.CBEstados = new System.Windows.Forms.CheckBox();
            this.DTFcreaciones = new System.Windows.Forms.DateTimePicker();
            this.DGVUMedidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoRadDataSet3 = new Presentacion.ProyectoRadDataSet3();
            this.proyectoRadDataSet2 = new Presentacion.ProyectoRadDataSet2();
            this.proyectoRadDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadMedidasTableAdapter = new Presentacion.ProyectoRadDataSet3TableAdapters.UnidadMedidasTableAdapter();
            this.BtnGuarda = new System.Windows.Forms.Button();
            this.BtnModifica = new System.Windows.Forms.Button();
            this.BtnElimina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUMedidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(294, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "UNIDAD DE MEDIDA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Codigo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Descripción:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Fecha de creación:";
            // 
            // TXTIDS
            // 
            this.TXTIDS.Enabled = false;
            this.TXTIDS.Location = new System.Drawing.Point(185, 42);
            this.TXTIDS.Name = "TXTIDS";
            this.TXTIDS.Size = new System.Drawing.Size(309, 26);
            this.TXTIDS.TabIndex = 6;
            // 
            // Txtcodig
            // 
            this.Txtcodig.Location = new System.Drawing.Point(185, 87);
            this.Txtcodig.Name = "Txtcodig";
            this.Txtcodig.Size = new System.Drawing.Size(309, 26);
            this.Txtcodig.TabIndex = 7;
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.Location = new System.Drawing.Point(185, 137);
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.Size = new System.Drawing.Size(309, 26);
            this.TxtDescrip.TabIndex = 8;
            // 
            // CBEstados
            // 
            this.CBEstados.AutoSize = true;
            this.CBEstados.Location = new System.Drawing.Point(185, 192);
            this.CBEstados.Name = "CBEstados";
            this.CBEstados.Size = new System.Drawing.Size(78, 24);
            this.CBEstados.TabIndex = 9;
            this.CBEstados.Text = "Activo";
            this.CBEstados.UseVisualStyleBackColor = true;
            // 
            // DTFcreaciones
            // 
            this.DTFcreaciones.Location = new System.Drawing.Point(185, 242);
            this.DTFcreaciones.Name = "DTFcreaciones";
            this.DTFcreaciones.Size = new System.Drawing.Size(346, 26);
            this.DTFcreaciones.TabIndex = 10;
            // 
            // DGVUMedidas
            // 
            this.DGVUMedidas.AllowUserToDeleteRows = false;
            this.DGVUMedidas.AutoGenerateColumns = false;
            this.DGVUMedidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUMedidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.DGVUMedidas.DataSource = this.bindingSource1;
            this.DGVUMedidas.Location = new System.Drawing.Point(16, 274);
            this.DGVUMedidas.Name = "DGVUMedidas";
            this.DGVUMedidas.ReadOnly = true;
            this.DGVUMedidas.RowHeadersWidth = 62;
            this.DGVUMedidas.RowTemplate.Height = 28;
            this.DGVUMedidas.Size = new System.Drawing.Size(864, 150);
            this.DGVUMedidas.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UnidadMedidaId";
            this.dataGridViewTextBoxColumn1.HeaderText = "UnidadMedidaId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaCreacion";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaCreacion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "UnidadMedidas";
            this.bindingSource1.DataSource = this.proyectoRadDataSet3;
            // 
            // proyectoRadDataSet3
            // 
            this.proyectoRadDataSet3.DataSetName = "ProyectoRadDataSet3";
            this.proyectoRadDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRadDataSet2
            // 
            this.proyectoRadDataSet2.DataSetName = "ProyectoRadDataSet2";
            this.proyectoRadDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoRadDataSet2BindingSource
            // 
            this.proyectoRadDataSet2BindingSource.DataSource = this.proyectoRadDataSet2;
            this.proyectoRadDataSet2BindingSource.Position = 0;
            // 
            // unidadMedidasTableAdapter
            // 
            this.unidadMedidasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnGuarda
            // 
            this.BtnGuarda.Location = new System.Drawing.Point(473, 177);
            this.BtnGuarda.Name = "BtnGuarda";
            this.BtnGuarda.Size = new System.Drawing.Size(117, 50);
            this.BtnGuarda.TabIndex = 20;
            this.BtnGuarda.Text = "Guardar";
            this.BtnGuarda.UseVisualStyleBackColor = true;
            // 
            // BtnModifica
            // 
            this.BtnModifica.Location = new System.Drawing.Point(610, 177);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(117, 50);
            this.BtnModifica.TabIndex = 21;
            this.BtnModifica.Text = "Modificar";
            this.BtnModifica.UseVisualStyleBackColor = true;
            // 
            // BtnElimina
            // 
            this.BtnElimina.Location = new System.Drawing.Point(755, 177);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(117, 50);
            this.BtnElimina.TabIndex = 22;
            this.BtnElimina.Text = "Eliminar";
            this.BtnElimina.UseVisualStyleBackColor = true;
            // 
            // PUnidadMedida
            // 
            this.ClientSize = new System.Drawing.Size(891, 464);
            this.Controls.Add(this.BtnElimina);
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.BtnGuarda);
            this.Controls.Add(this.DGVUMedidas);
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
            this.Name = "PUnidadMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.PUnidadMedida_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUMedidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoRadDataSet2BindingSource)).EndInit();
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
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DGVMedida;
        private System.Windows.Forms.BindingSource unidadMedidasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadMedidaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.CheckBox CBEstado;
        private System.Windows.Forms.DateTimePicker DTFCreacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTIDS;
        private System.Windows.Forms.TextBox Txtcodig;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.CheckBox CBEstados;
        private System.Windows.Forms.DateTimePicker DTFcreaciones;
        private System.Windows.Forms.DataGridView DGVUMedidas;
        private Presentacion.ProyectoRadDataSet2 proyectoRadDataSet2;
        private System.Windows.Forms.BindingSource proyectoRadDataSet2BindingSource;
        private Presentacion.ProyectoRadDataSet3 proyectoRadDataSet3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Presentacion.ProyectoRadDataSet3TableAdapters.UnidadMedidasTableAdapter unidadMedidasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button BtnGuarda;
        private System.Windows.Forms.Button BtnModifica;
        private System.Windows.Forms.Button BtnElimina;
    }
}