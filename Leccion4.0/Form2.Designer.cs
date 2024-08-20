namespace Leccion4._0
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            name = new TextBox();
            lastname = new TextBox();
            label3 = new Label();
            age = new TextBox();
            label4 = new Label();
            add = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Registro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(23, 44);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su nombre:";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 12F);
            name.Location = new Point(23, 71);
            name.Name = "name";
            name.Size = new Size(186, 29);
            name.TabIndex = 2;
            // 
            // lastname
            // 
            lastname.Font = new Font("Segoe UI", 12F);
            lastname.Location = new Point(23, 133);
            lastname.Name = "lastname";
            lastname.Size = new Size(186, 29);
            lastname.TabIndex = 4;
            lastname.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(23, 103);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 3;
            label3.Text = "Ingrese su apellido:";
            // 
            // age
            // 
            age.Font = new Font("Segoe UI", 12F);
            age.Location = new Point(23, 189);
            age.Name = "age";
            age.Size = new Size(122, 29);
            age.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(23, 165);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 5;
            label4.Text = "Ingrese su edad:";
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 12F);
            add.Location = new Point(23, 230);
            add.Name = "add";
            add.Size = new Size(88, 42);
            add.TabIndex = 7;
            add.Text = "AÑADIR";
            add.UseVisualStyleBackColor = true;
            add.Click += button1_Click;
            // 
            // delete
            // 
            delete.Font = new Font("Segoe UI", 12F);
            delete.Location = new Point(23, 278);
            delete.Name = "delete";
            delete.Size = new Size(88, 42);
            delete.TabIndex = 8;
            delete.Text = "BORRAR";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(300, 197);
            dataGridView1.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(age);
            Controls.Add(label4);
            Controls.Add(lastname);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private TextBox lastname;
        private Label label3;
        private TextBox age;
        private Label label4;
        private Button add;
        private Button delete;
        private DataGridView dataGridView1;
    }
}