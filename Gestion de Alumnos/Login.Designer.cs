namespace Gestion_de_Alumnos
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlLogoContainer = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRecuperarContraseña = new System.Windows.Forms.LinkLabel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLineasUsuario = new System.Windows.Forms.TextBox();
            this.txtLineasPass = new System.Windows.Forms.TextBox();
            this.pnlLogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogoContainer
            // 
            this.pnlLogoContainer.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlLogoContainer.Controls.Add(this.pbLogo);
            this.pnlLogoContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogoContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoContainer.Name = "pnlLogoContainer";
            this.pnlLogoContainer.Size = new System.Drawing.Size(250, 330);
            this.pnlLogoContainer.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(46, 100);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(144, 132);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Black;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(340, 113);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(284, 24);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Black;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(340, 194);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(380, 24);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(472, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.LightGray;
            this.btnIngresar.Location = new System.Drawing.Point(410, 254);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(207, 40);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.TabStop = false;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblRecuperarContraseña
            // 
            this.lblRecuperarContraseña.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lblRecuperarContraseña.AutoSize = true;
            this.lblRecuperarContraseña.LinkColor = System.Drawing.Color.DimGray;
            this.lblRecuperarContraseña.Location = new System.Drawing.Point(458, 304);
            this.lblRecuperarContraseña.Name = "lblRecuperarContraseña";
            this.lblRecuperarContraseña.Size = new System.Drawing.Size(114, 13);
            this.lblRecuperarContraseña.TabIndex = 0;
            this.lblRecuperarContraseña.TabStop = true;
            this.lblRecuperarContraseña.Text = "Recuperar Contraseña";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(753, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(19, 19);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(724, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(19, 19);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLineasUsuario
            // 
            this.txtLineasUsuario.BackColor = System.Drawing.Color.Black;
            this.txtLineasUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineasUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtLineasUsuario.Location = new System.Drawing.Point(341, 125);
            this.txtLineasUsuario.Name = "txtLineasUsuario";
            this.txtLineasUsuario.Size = new System.Drawing.Size(379, 13);
            this.txtLineasUsuario.TabIndex = 7;
            this.txtLineasUsuario.Text = "______________________________________________________________________";
            // 
            // txtLineasPass
            // 
            this.txtLineasPass.BackColor = System.Drawing.Color.Black;
            this.txtLineasPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineasPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtLineasPass.Location = new System.Drawing.Point(341, 206);
            this.txtLineasPass.Name = "txtLineasPass";
            this.txtLineasPass.Size = new System.Drawing.Size(379, 13);
            this.txtLineasPass.TabIndex = 7;
            this.txtLineasPass.Text = "______________________________________________________________________";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtLineasPass);
            this.Controls.Add(this.txtLineasUsuario);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblRecuperarContraseña);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlLogoContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlLogoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogoContainer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lblRecuperarContraseña;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtLineasUsuario;
        private System.Windows.Forms.TextBox txtLineasPass;
    }
}

