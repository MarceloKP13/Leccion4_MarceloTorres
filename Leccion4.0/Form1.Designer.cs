namespace Leccion4._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            text1 = new Label();
            text2 = new Label();
            text3 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            suma = new CheckBox();
            resta = new CheckBox();
            multi = new CheckBox();
            divi = new CheckBox();
            modulo = new CheckBox();
            raiz = new CheckBox();
            calcular = new Button();
            nueva = new Button();
            SuspendLayout();
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text1.Location = new Point(12, 9);
            text1.Name = "text1";
            text1.Size = new Size(194, 30);
            text1.TabIndex = 0;
            text1.Text = "Calculadora Básica";
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            text2.Location = new Point(12, 45);
            text2.Name = "text2";
            text2.Size = new Size(86, 21);
            text2.TabIndex = 1;
            text2.Text = "Número 1";
            // 
            // text3
            // 
            text3.AutoSize = true;
            text3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            text3.Location = new Point(12, 105);
            text3.Name = "text3";
            text3.Size = new Size(86, 21);
            text3.TabIndex = 2;
            text3.Text = "Número 2";
            // 
            // num1
            // 
            num1.Font = new Font("Segoe UI", 12F);
            num1.Location = new Point(12, 73);
            num1.Name = "num1";
            num1.Size = new Size(100, 29);
            num1.TabIndex = 3;
            // 
            // num2
            // 
            num2.Font = new Font("Segoe UI", 12F);
            num2.Location = new Point(12, 129);
            num2.Name = "num2";
            num2.Size = new Size(100, 29);
            num2.TabIndex = 4;
            // 
            // suma
            // 
            suma.AutoSize = true;
            suma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            suma.Location = new Point(12, 166);
            suma.Name = "suma";
            suma.Size = new Size(86, 25);
            suma.TabIndex = 5;
            suma.Text = "SUMAR";
            suma.UseVisualStyleBackColor = true;
            // 
            // resta
            // 
            resta.AutoSize = true;
            resta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resta.Location = new Point(12, 191);
            resta.Name = "resta";
            resta.Size = new Size(86, 25);
            resta.TabIndex = 6;
            resta.Text = "RESTAR";
            resta.UseVisualStyleBackColor = true;
            // 
            // multi
            // 
            multi.AutoSize = true;
            multi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            multi.Location = new Point(12, 216);
            multi.Name = "multi";
            multi.Size = new Size(131, 25);
            multi.TabIndex = 7;
            multi.Text = "MULTIPLICAR";
            multi.UseVisualStyleBackColor = true;
            // 
            // divi
            // 
            divi.AutoSize = true;
            divi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            divi.Location = new Point(12, 241);
            divi.Name = "divi";
            divi.Size = new Size(89, 25);
            divi.TabIndex = 8;
            divi.Text = "DIVIDIR";
            divi.UseVisualStyleBackColor = true;
            // 
            // modulo
            // 
            modulo.AutoSize = true;
            modulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            modulo.Location = new Point(12, 266);
            modulo.Name = "modulo";
            modulo.Size = new Size(100, 25);
            modulo.TabIndex = 9;
            modulo.Text = "MÓDULO";
            modulo.UseVisualStyleBackColor = true;
            // 
            // raiz
            // 
            raiz.AutoSize = true;
            raiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            raiz.Location = new Point(12, 291);
            raiz.Name = "raiz";
            raiz.Size = new Size(158, 25);
            raiz.TabIndex = 10;
            raiz.Text = "RAIZ CUADRADA";
            raiz.UseVisualStyleBackColor = true;
            // 
            // calcular
            // 
            calcular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calcular.Location = new Point(12, 329);
            calcular.Name = "calcular";
            calcular.Size = new Size(100, 35);
            calcular.TabIndex = 11;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // nueva
            // 
            nueva.Font = new Font("Segoe UI", 12F);
            nueva.Location = new Point(192, 401);
            nueva.Name = "nueva";
            nueva.Size = new Size(142, 37);
            nueva.TabIndex = 12;
            nueva.Text = "Nueva Actividad";
            nueva.UseVisualStyleBackColor = true;
            nueva.Click += nueva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(346, 450);
            Controls.Add(nueva);
            Controls.Add(calcular);
            Controls.Add(raiz);
            Controls.Add(modulo);
            Controls.Add(divi);
            Controls.Add(multi);
            Controls.Add(resta);
            Controls.Add(suma);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(text1);
            Name = "Form1";
            Text = "Calculadora Básica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text1;
        private Label text2;
        private Label text3;
        private TextBox num1;
        private TextBox num2;
        private CheckBox suma;
        private CheckBox resta;
        private CheckBox multi;
        private CheckBox divi;
        private CheckBox modulo;
        private CheckBox raiz;
        private Button calcular;
        private Button nueva;
    }
}
