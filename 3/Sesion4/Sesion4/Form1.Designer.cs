namespace Sesion4
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
            this.label = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAumento = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTecho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(71, 41);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 16);
            this.label.TabIndex = 0;
            this.label.Text = "Salario:";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(146, 38);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(396, 22);
            this.tbSalario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aumento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudAumento
            // 
            this.nudAumento.Location = new System.Drawing.Point(146, 82);
            this.nudAumento.Name = "nudAumento";
            this.nudAumento.Size = new System.Drawing.Size(131, 22);
            this.nudAumento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Techo";
            // 
            // tbTecho
            // 
            this.tbTecho.Location = new System.Drawing.Point(146, 125);
            this.tbTecho.Name = "tbTecho";
            this.tbTecho.Size = new System.Drawing.Size(143, 22);
            this.tbTecho.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTecho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTecho;
    }
}

