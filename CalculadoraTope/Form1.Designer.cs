namespace CalculadoraTope
{
    partial class CALCULADORA
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
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.btn_Multiplicacion = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Igualdad = new System.Windows.Forms.Button();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(79, 70);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(164, 20);
            this.txt_Numero.TabIndex = 0;
            // 
            // btn_Suma
            // 
            this.btn_Suma.Location = new System.Drawing.Point(79, 122);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(45, 40);
            this.btn_Suma.TabIndex = 1;
            this.btn_Suma.Text = "+";
            this.btn_Suma.UseVisualStyleBackColor = true;
            this.btn_Suma.Click += new System.EventHandler(this.btn_Suma_Click);
            // 
            // btn_Resta
            // 
            this.btn_Resta.Location = new System.Drawing.Point(135, 122);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(44, 40);
            this.btn_Resta.TabIndex = 2;
            this.btn_Resta.Text = "-";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.btn_Resta_Click);
            // 
            // btn_Multiplicacion
            // 
            this.btn_Multiplicacion.Location = new System.Drawing.Point(79, 177);
            this.btn_Multiplicacion.Name = "btn_Multiplicacion";
            this.btn_Multiplicacion.Size = new System.Drawing.Size(45, 40);
            this.btn_Multiplicacion.TabIndex = 3;
            this.btn_Multiplicacion.Text = "x";
            this.btn_Multiplicacion.UseVisualStyleBackColor = true;
            this.btn_Multiplicacion.Click += new System.EventHandler(this.btn_Multiplicacion_Click);
            // 
            // btn_Division
            // 
            this.btn_Division.Location = new System.Drawing.Point(135, 177);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(44, 40);
            this.btn_Division.TabIndex = 4;
            this.btn_Division.Text = "/";
            this.btn_Division.UseVisualStyleBackColor = true;
            this.btn_Division.Click += new System.EventHandler(this.btn_Division_Click);
            // 
            // btn_Igualdad
            // 
            this.btn_Igualdad.Location = new System.Drawing.Point(194, 123);
            this.btn_Igualdad.Name = "btn_Igualdad";
            this.btn_Igualdad.Size = new System.Drawing.Size(49, 94);
            this.btn_Igualdad.TabIndex = 5;
            this.btn_Igualdad.Text = "=";
            this.btn_Igualdad.UseVisualStyleBackColor = true;
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.Location = new System.Drawing.Point(28, 122);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(45, 40);
            this.btn_Reiniciar.TabIndex = 6;
            this.btn_Reiniciar.Text = "CE";
            this.btn_Reiniciar.UseVisualStyleBackColor = true;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btn_Reiniciar_Click);
            // 
            // CALCULADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 257);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.btn_Igualdad);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Multiplicacion);
            this.Controls.Add(this.btn_Resta);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.txt_Numero);
            this.Name = "CALCULADORA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn_Multiplicacion;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Igualdad;
        private System.Windows.Forms.Button btn_Reiniciar;
    }
}

