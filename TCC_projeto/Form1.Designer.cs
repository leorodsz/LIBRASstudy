namespace Cadastro
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            botao_entrar = new Button();
            botao_cadastrar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(290, 128);
            label2.Name = "label2";
            label2.Size = new Size(132, 35);
            label2.TabIndex = 1;
            label2.Text = "Entrar";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(290, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(97, 213);
            label1.Name = "label1";
            label1.Size = new Size(187, 35);
            label1.TabIndex = 3;
            label1.Text = "Nome de usuário";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(290, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(206, 253);
            label3.Name = "label3";
            label3.Size = new Size(78, 35);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(290, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(206, 292);
            label4.Name = "label4";
            label4.Size = new Size(78, 35);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // botao_entrar
            // 
            botao_entrar.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botao_entrar.Location = new Point(290, 350);
            botao_entrar.Name = "botao_entrar";
            botao_entrar.Size = new Size(84, 50);
            botao_entrar.TabIndex = 8;
            botao_entrar.Text = "Entrar";
            botao_entrar.UseVisualStyleBackColor = true;
            botao_entrar.Click += button1_Click;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botao_cadastrar.Location = new Point(413, 350);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(89, 50);
            botao_cadastrar.TabIndex = 9;
            botao_cadastrar.Text = "Cadastrar";
            botao_cadastrar.UseVisualStyleBackColor = true;
            botao_cadastrar.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(413, 403);
            label5.Name = "label5";
            label5.Size = new Size(109, 12);
            label5.TabIndex = 10;
            label5.Text = "Não possui uma conta?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(413, 418);
            label6.Name = "label6";
            label6.Size = new Size(55, 12);
            label6.TabIndex = 11;
            label6.Text = "Cadastre-se";
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(149, 41);
            label8.Name = "label8";
            label8.Size = new Size(429, 38);
            label8.TabIndex = 12;
            label8.Text = "Bem vindos ao Libras Study";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(784, 449);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(botao_cadastrar);
            Controls.Add(botao_entrar);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Libras Study";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button botao_entrar;
        private Button botao_cadastrar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
