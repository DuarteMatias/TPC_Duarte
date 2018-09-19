namespace Gestion_de_Alumnos
{
    partial class frmListadoDocentes
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
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.bntRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDocentes.Location = new System.Drawing.Point(130, 110);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(1200, 700);
            this.dgvDocentes.TabIndex = 0;
            // 
            // bntRegresar
            // 
            this.bntRegresar.Location = new System.Drawing.Point(1326, 848);
            this.bntRegresar.Name = "bntRegresar";
            this.bntRegresar.Size = new System.Drawing.Size(102, 40);
            this.bntRegresar.TabIndex = 1;
            this.bntRegresar.Text = "Regresar al\r\nMenu Principal";
            this.bntRegresar.UseVisualStyleBackColor = true;
            this.bntRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 15);
            this.panel1.TabIndex = 2;
            // 
            // frmListadoDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntRegresar);
            this.Controls.Add(this.dgvDocentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListadoDocentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmListadoDocentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button bntRegresar;
        private System.Windows.Forms.Panel panel1;
    }
}