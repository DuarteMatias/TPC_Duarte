﻿namespace Gestion_de_Alumnos
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
            this.btnAltas = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.btnModificaciones = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltas
            // 
            this.btnAltas.Location = new System.Drawing.Point(122, 377);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(190, 150);
            this.btnAltas.TabIndex = 0;
            this.btnAltas.Text = "ALTAS";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // btnBajas
            // 
            this.btnBajas.Location = new System.Drawing.Point(385, 377);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(190, 150);
            this.btnBajas.TabIndex = 0;
            this.btnBajas.Text = "BAJAS";
            this.btnBajas.UseVisualStyleBackColor = true;
            // 
            // btnModificaciones
            // 
            this.btnModificaciones.Location = new System.Drawing.Point(648, 377);
            this.btnModificaciones.Name = "btnModificaciones";
            this.btnModificaciones.Size = new System.Drawing.Size(190, 150);
            this.btnModificaciones.TabIndex = 0;
            this.btnModificaciones.Text = "MODIFICACIONES";
            this.btnModificaciones.UseVisualStyleBackColor = true;
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(911, 377);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(190, 150);
            this.btnListado.TabIndex = 0;
            this.btnListado.Text = "LISTADO DE\r\n\r\nALUMNOS";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // ControlUsuarioAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnModificaciones);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnAltas);
            this.Name = "ControlUsuarioAlumnos";
            this.Size = new System.Drawing.Size(1240, 730);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Button btnModificaciones;
        private System.Windows.Forms.Button btnListado;
    }
}
