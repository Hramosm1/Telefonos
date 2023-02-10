
namespace TelefonosScrapt.Formularios
{
    partial class FrmSeleccionProcesarArchivo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.txtNombreConsulta = new System.Windows.Forms.TextBox();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.gboxDetallesDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelarConf = new System.Windows.Forms.Button();
            this.btnGuardarConfiguracion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreConf = new System.Windows.Forms.TextBox();
            this.dgvCondiciones = new System.Windows.Forms.DataGridView();
            this.Condiciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCampos = new System.Windows.Forms.Label();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.NombreCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblNombreTabla = new System.Windows.Forms.Label();
            this.cmbFormaData = new System.Windows.Forms.ComboBox();
            this.lblForma = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblConfiguracionG = new System.Windows.Forms.Label();
            this.cmbConfiguraciones = new System.Windows.Forms.ComboBox();
            this.btnNuevaConfiguracion = new System.Windows.Forms.Button();
            this.gboxDetallesDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(669, 33);
            this.pnSuperior.TabIndex = 2;
            // 
            // txtNombreConsulta
            // 
            this.txtNombreConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreConsulta.Location = new System.Drawing.Point(14, 93);
            this.txtNombreConsulta.MaxLength = 1250;
            this.txtNombreConsulta.Name = "txtNombreConsulta";
            this.txtNombreConsulta.Size = new System.Drawing.Size(245, 22);
            this.txtNombreConsulta.TabIndex = 9;
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondiciones.Location = new System.Drawing.Point(262, 180);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(168, 16);
            this.lblCondiciones.TabIndex = 11;
            this.lblCondiciones.Text = "Condiciones de la consulta:";
            // 
            // gboxDetallesDatos
            // 
            this.gboxDetallesDatos.Controls.Add(this.btnCancelarConf);
            this.gboxDetallesDatos.Controls.Add(this.btnGuardarConfiguracion);
            this.gboxDetallesDatos.Controls.Add(this.label1);
            this.gboxDetallesDatos.Controls.Add(this.txtNombreConf);
            this.gboxDetallesDatos.Controls.Add(this.dgvCondiciones);
            this.gboxDetallesDatos.Controls.Add(this.lblCampos);
            this.gboxDetallesDatos.Controls.Add(this.dgvCampos);
            this.gboxDetallesDatos.Controls.Add(this.lblSeleccion);
            this.gboxDetallesDatos.Controls.Add(this.lblCondiciones);
            this.gboxDetallesDatos.Controls.Add(this.lblNombreTabla);
            this.gboxDetallesDatos.Controls.Add(this.txtNombreConsulta);
            this.gboxDetallesDatos.Enabled = false;
            this.gboxDetallesDatos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDetallesDatos.Location = new System.Drawing.Point(13, 90);
            this.gboxDetallesDatos.Name = "gboxDetallesDatos";
            this.gboxDetallesDatos.Size = new System.Drawing.Size(641, 346);
            this.gboxDetallesDatos.TabIndex = 12;
            this.gboxDetallesDatos.TabStop = false;
            // 
            // btnCancelarConf
            // 
            this.btnCancelarConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnCancelarConf.FlatAppearance.BorderSize = 0;
            this.btnCancelarConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarConf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarConf.ForeColor = System.Drawing.Color.White;
            this.btnCancelarConf.Location = new System.Drawing.Point(14, 152);
            this.btnCancelarConf.Name = "btnCancelarConf";
            this.btnCancelarConf.Size = new System.Drawing.Size(245, 25);
            this.btnCancelarConf.TabIndex = 21;
            this.btnCancelarConf.Text = "Cancelar configuración";
            this.btnCancelarConf.UseVisualStyleBackColor = false;
            this.btnCancelarConf.Click += new System.EventHandler(this.btnCancelarConf_Click);
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnGuardarConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnGuardarConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConfiguracion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(14, 121);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(245, 25);
            this.btnGuardarConfiguracion.TabIndex = 20;
            this.btnGuardarConfiguracion.Text = "Guardar configuración";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = false;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre de la configuración:";
            // 
            // txtNombreConf
            // 
            this.txtNombreConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreConf.Location = new System.Drawing.Point(14, 46);
            this.txtNombreConf.MaxLength = 200;
            this.txtNombreConf.Name = "txtNombreConf";
            this.txtNombreConf.Size = new System.Drawing.Size(245, 22);
            this.txtNombreConf.TabIndex = 18;
            // 
            // dgvCondiciones
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCondiciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCondiciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCondiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Condiciones,
            this.ValorCondicion});
            this.dgvCondiciones.EnableHeadersVisualStyles = false;
            this.dgvCondiciones.Location = new System.Drawing.Point(265, 198);
            this.dgvCondiciones.Name = "dgvCondiciones";
            this.dgvCondiciones.RowHeadersVisible = false;
            this.dgvCondiciones.Size = new System.Drawing.Size(361, 131);
            this.dgvCondiciones.TabIndex = 16;
            // 
            // Condiciones
            // 
            this.Condiciones.HeaderText = "Condicion";
            this.Condiciones.Name = "Condiciones";
            this.Condiciones.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Condiciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Condiciones.Width = 150;
            // 
            // ValorCondicion
            // 
            this.ValorCondicion.HeaderText = "Valor de la condición";
            this.ValorCondicion.MaxInputLength = 1250;
            this.ValorCondicion.Name = "ValorCondicion";
            this.ValorCondicion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorCondicion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValorCondicion.Width = 200;
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampos.Location = new System.Drawing.Point(262, 28);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(146, 16);
            this.lblCampos.TabIndex = 15;
            this.lblCampos.Text = "Nombre de los campos:";
            // 
            // dgvCampos
            // 
            this.dgvCampos.AllowUserToAddRows = false;
            this.dgvCampos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCampos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCampos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCampo,
            this.NombreTabla});
            this.dgvCampos.EnableHeadersVisualStyles = false;
            this.dgvCampos.Location = new System.Drawing.Point(265, 46);
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.RowHeadersVisible = false;
            this.dgvCampos.Size = new System.Drawing.Size(361, 131);
            this.dgvCampos.TabIndex = 14;
            // 
            // NombreCampo
            // 
            this.NombreCampo.HeaderText = "Nombre del campo";
            this.NombreCampo.Name = "NombreCampo";
            this.NombreCampo.ReadOnly = true;
            this.NombreCampo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCampo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCampo.Width = 150;
            // 
            // NombreTabla
            // 
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTabla.DefaultCellStyle = dataGridViewCellStyle20;
            this.NombreTabla.HeaderText = "Nombre del campo BD";
            this.NombreTabla.MaxInputLength = 1250;
            this.NombreTabla.Name = "NombreTabla";
            this.NombreTabla.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreTabla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreTabla.Width = 200;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(-3, -2);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(235, 16);
            this.lblSeleccion.TabIndex = 13;
            this.lblSeleccion.Text = "Coloque las condiciones de la data:";
            // 
            // lblNombreTabla
            // 
            this.lblNombreTabla.AutoSize = true;
            this.lblNombreTabla.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTabla.Location = new System.Drawing.Point(11, 74);
            this.lblNombreTabla.Name = "lblNombreTabla";
            this.lblNombreTabla.Size = new System.Drawing.Size(121, 16);
            this.lblNombreTabla.TabIndex = 7;
            this.lblNombreTabla.Text = "Nombre de la tabla:";
            // 
            // cmbFormaData
            // 
            this.cmbFormaData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaData.FormattingEnabled = true;
            this.cmbFormaData.Items.AddRange(new object[] {
            "Excel",
            "Base de datos"});
            this.cmbFormaData.Location = new System.Drawing.Point(13, 63);
            this.cmbFormaData.Name = "cmbFormaData";
            this.cmbFormaData.Size = new System.Drawing.Size(261, 21);
            this.cmbFormaData.TabIndex = 13;
            this.cmbFormaData.SelectedIndexChanged += new System.EventHandler(this.cmbFormaData_SelectedIndexChanged);
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForma.Location = new System.Drawing.Point(10, 45);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(150, 16);
            this.lblForma.TabIndex = 14;
            this.lblForma.Text = "Forma de cargar la data:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(16, 442);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 25);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(106, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 25);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblConfiguracionG
            // 
            this.lblConfiguracionG.AutoSize = true;
            this.lblConfiguracionG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiguracionG.Location = new System.Drawing.Point(287, 45);
            this.lblConfiguracionG.Name = "lblConfiguracionG";
            this.lblConfiguracionG.Size = new System.Drawing.Size(168, 16);
            this.lblConfiguracionG.TabIndex = 18;
            this.lblConfiguracionG.Text = "Configuraciónes guardadas:";
            // 
            // cmbConfiguraciones
            // 
            this.cmbConfiguraciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfiguraciones.Enabled = false;
            this.cmbConfiguraciones.FormattingEnabled = true;
            this.cmbConfiguraciones.Location = new System.Drawing.Point(290, 63);
            this.cmbConfiguraciones.Name = "cmbConfiguraciones";
            this.cmbConfiguraciones.Size = new System.Drawing.Size(261, 21);
            this.cmbConfiguraciones.TabIndex = 17;
            // 
            // btnNuevaConfiguracion
            // 
            this.btnNuevaConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnNuevaConfiguracion.Enabled = false;
            this.btnNuevaConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnNuevaConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaConfiguracion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnNuevaConfiguracion.Location = new System.Drawing.Point(557, 60);
            this.btnNuevaConfiguracion.Name = "btnNuevaConfiguracion";
            this.btnNuevaConfiguracion.Size = new System.Drawing.Size(97, 25);
            this.btnNuevaConfiguracion.TabIndex = 19;
            this.btnNuevaConfiguracion.Text = "Nuevo";
            this.btnNuevaConfiguracion.UseVisualStyleBackColor = false;
            this.btnNuevaConfiguracion.Click += new System.EventHandler(this.btnNuevaConfiguracion_Click);
            // 
            // FrmSeleccionProcesarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 479);
            this.Controls.Add(this.btnNuevaConfiguracion);
            this.Controls.Add(this.lblConfiguracionG);
            this.Controls.Add(this.cmbConfiguraciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.cmbFormaData);
            this.Controls.Add(this.gboxDetallesDatos);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleccionProcesarArchivo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.FrmSeleccionProcesarArchivo_Load);
            this.gboxDetallesDatos.ResumeLayout(false);
            this.gboxDetallesDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.TextBox txtNombreConsulta;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.GroupBox gboxDetallesDatos;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblNombreTabla;
        private System.Windows.Forms.ComboBox cmbFormaData;
        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.DataGridView dgvCondiciones;
        private System.Windows.Forms.Label lblConfiguracionG;
        private System.Windows.Forms.ComboBox cmbConfiguraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreConf;
        private System.Windows.Forms.Button btnNuevaConfiguracion;
        private System.Windows.Forms.Button btnCancelarConf;
        private System.Windows.Forms.Button btnGuardarConfiguracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTabla;
    }
}