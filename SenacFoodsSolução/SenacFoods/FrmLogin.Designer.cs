namespace SenacFoods
{
    partial class FrmLogin
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnEntrada = new Button();
            textSenha = new TextBox();
            textLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnfechar = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnfechar);
            panel2.Controls.Add(btnEntrada);
            panel2.Controls.Add(textSenha);
            panel2.Controls.Add(textLogin);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(322, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(478, 450);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnEntrada
            // 
            btnEntrada.BackColor = Color.Black;
            btnEntrada.FlatStyle = FlatStyle.Flat;
            btnEntrada.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrada.ForeColor = Color.White;
            btnEntrada.Location = new Point(114, 273);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(220, 43);
            btnEntrada.TabIndex = 2;
            btnEntrada.Text = "Entrar";
            btnEntrada.UseVisualStyleBackColor = false;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // textSenha
            // 
            textSenha.BackColor = Color.Black;
            textSenha.BorderStyle = BorderStyle.None;
            textSenha.Font = new Font("Perpetua Titling MT", 18F);
            textSenha.ForeColor = Color.White;
            textSenha.Location = new Point(99, 170);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(261, 43);
            textSenha.TabIndex = 0;
            textSenha.Text = "Senha:";
            // 
            // textLogin
            // 
            textLogin.BackColor = Color.Black;
            textLogin.BorderStyle = BorderStyle.None;
            textLogin.Font = new Font("Perpetua Titling MT", 18F);
            textLogin.ForeColor = Color.White;
            textLogin.Location = new Point(99, 75);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(261, 43);
            textLogin.TabIndex = 0;
            textLogin.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(99, 100);
            label2.Name = "label2";
            label2.Size = new Size(264, 25);
            label2.TabIndex = 1;
            label2.Text = "____________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 197);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 1;
            label1.Text = "___________________________________";
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Black;
            btnfechar.Font = new Font("Segoe UI", 11F);
            btnfechar.ForeColor = Color.White;
            btnfechar.Location = new Point(382, 12);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(74, 34);
            btnfechar.TabIndex = 3;
            btnfechar.Text = "X";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textLogin;
        private TextBox textSenha;
        private Label label2;
        private Label label1;
        private Button btnEntrada;
        private Button btnfechar;
    }
}
