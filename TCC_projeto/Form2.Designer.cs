namespace Cadastro
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
            label3 = new Label();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(317, 78);
            label1.Name = "label1";
            label1.Size = new Size(151, 38);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 172);
            label2.Name = "label2";
            label2.Size = new Size(278, 26);
            label2.TabIndex = 1;
            label2.Text = "Insira seu nome de usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(133, 219);
            label3.Name = "label3";
            label3.Size = new Size(169, 26);
            label3.TabIndex = 2;
            label3.Text = "Insira seu email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 269);
            label4.Name = "label4";
            label4.Size = new Size(158, 26);
            label4.TabIndex = 3;
            label4.Text = "Crie sua senha";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(317, 176);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(217, 23);
            maskedTextBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(317, 338);
            button1.Name = "button1";
            button1.Size = new Size(95, 49);
            button1.TabIndex = 7;
            button1.Text = "Criar conta";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Cadastro de usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}