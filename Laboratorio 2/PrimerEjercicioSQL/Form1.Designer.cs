namespace PrimerEjercicioSQL
{
    partial class Form1
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
            this.dtgTabla = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtEdadAFiltrar = new System.Windows.Forms.TextBox();
            this.lblEdadAFiltrar = new System.Windows.Forms.Label();
            this.btnInsertarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgTabla
            // 
            this.dtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabla.Location = new System.Drawing.Point(12, 121);
            this.dtgTabla.Name = "dtgTabla";
            this.dtgTabla.Size = new System.Drawing.Size(601, 212);
            this.dtgTabla.TabIndex = 0;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(203, 92);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Buscar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtEdadAFiltrar
            // 
            this.txtEdadAFiltrar.Location = new System.Drawing.Point(88, 92);
            this.txtEdadAFiltrar.Name = "txtEdadAFiltrar";
            this.txtEdadAFiltrar.Size = new System.Drawing.Size(100, 20);
            this.txtEdadAFiltrar.TabIndex = 2;
            // 
            // lblEdadAFiltrar
            // 
            this.lblEdadAFiltrar.AutoSize = true;
            this.lblEdadAFiltrar.Location = new System.Drawing.Point(9, 92);
            this.lblEdadAFiltrar.Name = "lblEdadAFiltrar";
            this.lblEdadAFiltrar.Size = new System.Drawing.Size(73, 13);
            this.lblEdadAFiltrar.TabIndex = 3;
            this.lblEdadAFiltrar.Text = "Edad A Filtrar:";
            // 
            // btnInsertarDatos
            // 
            this.btnInsertarDatos.Location = new System.Drawing.Point(296, 92);
            this.btnInsertarDatos.Name = "btnInsertarDatos";
            this.btnInsertarDatos.Size = new System.Drawing.Size(97, 23);
            this.btnInsertarDatos.TabIndex = 4;
            this.btnInsertarDatos.Text = "Insertar Datos";
            this.btnInsertarDatos.UseVisualStyleBackColor = true;
            this.btnInsertarDatos.Click += new System.EventHandler(this.btnInsertarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 345);
            this.Controls.Add(this.btnInsertarDatos);
            this.Controls.Add(this.lblEdadAFiltrar);
            this.Controls.Add(this.txtEdadAFiltrar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.dtgTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgTabla;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtEdadAFiltrar;
        private System.Windows.Forms.Label lblEdadAFiltrar;
        private System.Windows.Forms.Button btnInsertarDatos;
    }
}

