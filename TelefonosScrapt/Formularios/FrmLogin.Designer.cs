
namespace TelefonosScrapt
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnIcono = new System.Windows.Forms.Panel();
            this.pnDatosLogin = new System.Windows.Forms.Panel();
            this.pictContraseña = new System.Windows.Forms.PictureBox();
            this.pictUsuario = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pictIcono = new System.Windows.Forms.PictureBox();
            this.pnIcono.SuspendLayout();
            this.pnDatosLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // pnIcono
            // 
            this.pnIcono.BackColor = System.Drawing.Color.White;
            this.pnIcono.Controls.Add(this.pnDatosLogin);
            this.pnIcono.Controls.Add(this.lblTexto);
            this.pnIcono.Controls.Add(this.pictIcono);
            this.pnIcono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnIcono.Location = new System.Drawing.Point(0, 0);
            this.pnIcono.Name = "pnIcono";
            this.pnIcono.Size = new System.Drawing.Size(337, 411);
            this.pnIcono.TabIndex = 2;
            // 
            // pnDatosLogin
            // 
            this.pnDatosLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnDatosLogin.Controls.Add(this.pictContraseña);
            this.pnDatosLogin.Controls.Add(this.pictUsuario);
            this.pnDatosLogin.Controls.Add(this.btnInicio);
            this.pnDatosLogin.Controls.Add(this.txtContraseña);
            this.pnDatosLogin.Controls.Add(this.txtUsuario);
            this.pnDatosLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDatosLogin.Location = new System.Drawing.Point(0, 159);
            this.pnDatosLogin.Name = "pnDatosLogin";
            this.pnDatosLogin.Size = new System.Drawing.Size(337, 252);
            this.pnDatosLogin.TabIndex = 2;
            // 
            // pictContraseña
            // 
            this.pictContraseña.BackgroundImage = global::TelefonosScrapt.Properties.Resources.bloquearC;
            this.pictContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictContraseña.ErrorImage = null;
            this.pictContraseña.Location = new System.Drawing.Point(46, 102);
            this.pictContraseña.Name = "pictContraseña";
            this.pictContraseña.Size = new System.Drawing.Size(29, 31);
            this.pictContraseña.TabIndex = 13;
            this.pictContraseña.TabStop = false;
            // 
            // pictUsuario
            // 
            this.pictUsuario.BackgroundImage = global::TelefonosScrapt.Properties.Resources.usuarioC;
            this.pictUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictUsuario.Location = new System.Drawing.Point(46, 65);
            this.pictUsuario.Name = "pictUsuario";
            this.pictUsuario.Size = new System.Drawing.Size(29, 31);
            this.pictUsuario.TabIndex = 12;
            this.pictUsuario.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(199)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(46, 141);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(244, 39);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.Text = "Ingresar";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(81, 114);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(209, 21);
            this.txtContraseña.TabIndex = 10;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(81, 75);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(209, 21);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(78, 108);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(171, 23);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Teléfonos Guatemala";
            // 
            // pictIcono
            // 
            this.pictIcono.BackgroundImage = global::TelefonosScrapt.Properties.Resources.llamada_telefonica__5_;
            this.pictIcono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictIcono.Location = new System.Drawing.Point(130, 22);
            this.pictIcono.Name = "pictIcono";
            this.pictIcono.Size = new System.Drawing.Size(76, 83);
            this.pictIcono.TabIndex = 0;
            this.pictIcono.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 411);
            this.Controls.Add(this.pnIcono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido!";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnIcono.ResumeLayout(false);
            this.pnIcono.PerformLayout();
            this.pnDatosLogin.ResumeLayout(false);
            this.pnDatosLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnIcono;
        private System.Windows.Forms.PictureBox pictIcono;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Panel pnDatosLogin;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pictUsuario;
        private System.Windows.Forms.PictureBox pictContraseña;
    }
}

