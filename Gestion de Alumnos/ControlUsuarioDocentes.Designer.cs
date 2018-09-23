namespace Gestion_de_Alumnos
{
    partial class ControlUsuarioDocentes
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnListadoDocentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(122, 162);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(190, 150);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "ALTAS";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(385, 162);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(190, 150);
            this.btnBaja.TabIndex = 0;
            this.btnBaja.Text = "BAJAS";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 150);
            this.button3.TabIndex = 0;
            this.button3.Text = "MODIFICACIONES";
            // 
            // btnListadoDocentes
            // 
            this.btnListadoDocentes.Location = new System.Drawing.Point(911, 162);
            this.btnListadoDocentes.Name = "btnListadoDocentes";
            this.btnListadoDocentes.Size = new System.Drawing.Size(190, 150);
            this.btnListadoDocentes.TabIndex = 0;
            this.btnListadoDocentes.Text = "LISTADO DE\r\n\r\nDOCENTES";
            this.btnListadoDocentes.Click += new System.EventHandler(this.btnListadoDocentes_Click);
            // 
            // ControlUsuarioDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnListadoDocentes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.Name = "ControlUsuarioDocentes";
            this.Size = new System.Drawing.Size(1240, 730);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnListadoDocentes;
    }
}
