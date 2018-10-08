namespace Gestion_de_Alumnos
{
    partial class ControlUsuarioAlumnos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuarioAlumnos));
            this.btnAltas = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.lblAltas = new System.Windows.Forms.Label();
            this.btnBajasModificaciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAltas
            // 
            this.btnAltas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAltas.BackgroundImage")));
            this.btnAltas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAltas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltas.Location = new System.Drawing.Point(239, 72);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(190, 150);
            this.btnAltas.TabIndex = 0;
            this.btnAltas.Text = "\r\n";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListado.BackgroundImage")));
            this.btnListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListado.Location = new System.Drawing.Point(800, 72);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(190, 150);
            this.btnListado.TabIndex = 0;
            this.btnListado.Text = "\r\n";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // lblAltas
            // 
            this.lblAltas.AutoSize = true;
            this.lblAltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltas.Location = new System.Drawing.Point(284, 225);
            this.lblAltas.Name = "lblAltas";
            this.lblAltas.Size = new System.Drawing.Size(100, 31);
            this.lblAltas.TabIndex = 1;
            this.lblAltas.Text = "ALTAS";
            // 
            // btnBajasModificaciones
            // 
            this.btnBajasModificaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBajasModificaciones.BackgroundImage")));
            this.btnBajasModificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBajasModificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajasModificaciones.Location = new System.Drawing.Point(524, 72);
            this.btnBajasModificaciones.Name = "btnBajasModificaciones";
            this.btnBajasModificaciones.Size = new System.Drawing.Size(190, 150);
            this.btnBajasModificaciones.TabIndex = 0;
            this.btnBajasModificaciones.Text = "\r\n";
            this.btnBajasModificaciones.UseVisualStyleBackColor = true;
            this.btnBajasModificaciones.Click += new System.EventHandler(this.btnBajasModificaciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "BAJAS O\r\nMODIFICACIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 62);
            this.label3.TabIndex = 1;
            this.label3.Text = "LISTADO \r\nDE ALUMNOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ControlUsuarioAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAltas);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnBajasModificaciones);
            this.Controls.Add(this.btnAltas);
            this.Name = "ControlUsuarioAlumnos";
            this.Size = new System.Drawing.Size(1240, 730);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Label lblAltas;
        private System.Windows.Forms.Button btnBajasModificaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
