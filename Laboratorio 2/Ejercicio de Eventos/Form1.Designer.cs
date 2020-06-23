namespace Ejercicio_de_Eventos
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
            this.tbJugador1 = new System.Windows.Forms.TextBox();
            this.tbJugador2 = new System.Windows.Forms.TextBox();
            this.tbJugador3 = new System.Windows.Forms.TextBox();
            this.tbJugador4 = new System.Windows.Forms.TextBox();
            this.btnJugador1 = new System.Windows.Forms.Button();
            this.btnJugador2 = new System.Windows.Forms.Button();
            this.btnJugador3 = new System.Windows.Forms.Button();
            this.btnJugador4 = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbJugador1
            // 
            this.tbJugador1.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbJugador1.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbJugador1.Location = new System.Drawing.Point(3, 36);
            this.tbJugador1.Name = "tbJugador1";
            this.tbJugador1.Size = new System.Drawing.Size(100, 20);
            this.tbJugador1.TabIndex = 0;
            // 
            // tbJugador2
            // 
            this.tbJugador2.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbJugador2.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbJugador2.Location = new System.Drawing.Point(109, 36);
            this.tbJugador2.Name = "tbJugador2";
            this.tbJugador2.Size = new System.Drawing.Size(100, 20);
            this.tbJugador2.TabIndex = 1;
            // 
            // tbJugador3
            // 
            this.tbJugador3.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbJugador3.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbJugador3.Location = new System.Drawing.Point(215, 36);
            this.tbJugador3.Name = "tbJugador3";
            this.tbJugador3.Size = new System.Drawing.Size(100, 20);
            this.tbJugador3.TabIndex = 2;
            // 
            // tbJugador4
            // 
            this.tbJugador4.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbJugador4.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbJugador4.Location = new System.Drawing.Point(321, 36);
            this.tbJugador4.Name = "tbJugador4";
            this.tbJugador4.Size = new System.Drawing.Size(100, 20);
            this.tbJugador4.TabIndex = 3;
            // 
            // btnJugador1
            // 
            this.btnJugador1.Location = new System.Drawing.Point(12, 88);
            this.btnJugador1.Name = "btnJugador1";
            this.btnJugador1.Size = new System.Drawing.Size(75, 23);
            this.btnJugador1.TabIndex = 4;
            this.btnJugador1.Text = "Jugador 1";
            this.btnJugador1.UseVisualStyleBackColor = true;
            
            // 
            // btnJugador2
            // 
            this.btnJugador2.Location = new System.Drawing.Point(122, 88);
            this.btnJugador2.Name = "btnJugador2";
            this.btnJugador2.Size = new System.Drawing.Size(75, 23);
            this.btnJugador2.TabIndex = 5;
            this.btnJugador2.Text = "Jugador 2";
            this.btnJugador2.UseVisualStyleBackColor = true;
            
            // 
            // btnJugador3
            // 
            this.btnJugador3.Location = new System.Drawing.Point(230, 88);
            this.btnJugador3.Name = "btnJugador3";
            this.btnJugador3.Size = new System.Drawing.Size(75, 23);
            this.btnJugador3.TabIndex = 6;
            this.btnJugador3.Text = "Jugador 3";
            this.btnJugador3.UseVisualStyleBackColor = true;
            
            // 
            // btnJugador4
            // 
            this.btnJugador4.Location = new System.Drawing.Point(340, 88);
            this.btnJugador4.Name = "btnJugador4";
            this.btnJugador4.Size = new System.Drawing.Size(75, 23);
            this.btnJugador4.TabIndex = 7;
            this.btnJugador4.Text = "Jugador 4";
            this.btnJugador4.UseVisualStyleBackColor = true;
            
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(176, 153);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 8;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPuntaje.Location = new System.Drawing.Point(272, 158);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 9;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(427, 185);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.btnJugador4);
            this.Controls.Add(this.btnJugador3);
            this.Controls.Add(this.btnJugador2);
            this.Controls.Add(this.btnJugador1);
            this.Controls.Add(this.tbJugador4);
            this.Controls.Add(this.tbJugador3);
            this.Controls.Add(this.tbJugador2);
            this.Controls.Add(this.tbJugador1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbJugador1;
        private System.Windows.Forms.TextBox tbJugador2;
        private System.Windows.Forms.TextBox tbJugador3;
        private System.Windows.Forms.TextBox tbJugador4;
        private System.Windows.Forms.Button btnJugador1;
        private System.Windows.Forms.Button btnJugador2;
        private System.Windows.Forms.Button btnJugador3;
        private System.Windows.Forms.Button btnJugador4;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label lblPuntaje;
    }
}

