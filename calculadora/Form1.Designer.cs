namespace calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Basica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = " valor 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "valor 2";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(613, 99);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 3;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(613, 150);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 4;
            // 
            // btn_sumar
            // 
            this.btn_sumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sumar.Location = new System.Drawing.Point(88, 249);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(97, 36);
            this.btn_sumar.TabIndex = 5;
            this.btn_sumar.Text = "sumar";
            this.btn_sumar.UseVisualStyleBackColor = true;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(538, 249);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(97, 36);
            this.btn_division.TabIndex = 6;
            this.btn_division.Text = "division";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicar.Location = new System.Drawing.Point(375, 249);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(97, 36);
            this.btn_multiplicar.TabIndex = 7;
            this.btn_multiplicar.Text = "multiplicar";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_restar
            // 
            this.btn_restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restar.Location = new System.Drawing.Point(234, 249);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(97, 36);
            this.btn_restar.TabIndex = 8;
            this.btn_restar.Text = "restar";
            this.btn_restar.UseVisualStyleBackColor = true;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(322, 355);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "RESULTADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_restar);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_sumar);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label4;
    }
}

