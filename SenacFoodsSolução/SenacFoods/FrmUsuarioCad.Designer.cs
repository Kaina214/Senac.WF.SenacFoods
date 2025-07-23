namespace SenacFoods
{
    partial class FrmUsuarioCad
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
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            panel1 = new Panel();
            btnfechar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            TxtNomeCompleto = new TextBox();
            textBox5 = new TextBox();
            TxtEMail = new TextBox();
            textBox7 = new TextBox();
            TextSenha = new TextBox();
            textBox9 = new TextBox();
            TextConfirmacaoDeSenha = new TextBox();
            TxtPerfilDoUsuário = new TextBox();
            comboBoxPerfilDoUsuario = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.ForeColor = Color.FloralWhite;
            BtnCancelar.Location = new Point(555, 367);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(112, 37);
            BtnCancelar.TabIndex = 0;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.Gold;
            BtnSalvar.Location = new Point(673, 370);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(112, 34);
            BtnSalvar.TabIndex = 1;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(btnfechar);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 94);
            panel1.TabIndex = 2;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Black;
            btnfechar.Font = new Font("Segoe UI", 11F);
            btnfechar.ForeColor = Color.White;
            btnfechar.Location = new Point(744, 0);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(55, 48);
            btnfechar.TabIndex = 8;
            btnfechar.Text = "X";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.Transparent;
            textBox1.Location = new Point(44, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 32);
            textBox1.TabIndex = 3;
            textBox1.Text = "Cad Usurario";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.Location = new Point(12, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "Cadastro do usuário :";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkGray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.Location = new Point(12, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 27);
            textBox3.TabIndex = 4;
            textBox3.Text = "Nome Completo :";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // TxtNomeCompleto
            // 
            TxtNomeCompleto.BorderStyle = BorderStyle.None;
            TxtNomeCompleto.Location = new Point(176, 167);
            TxtNomeCompleto.Name = "TxtNomeCompleto";
            TxtNomeCompleto.Size = new Size(259, 24);
            TxtNomeCompleto.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.DarkGray;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 10F);
            textBox5.Location = new Point(468, 167);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(86, 27);
            textBox5.TabIndex = 6;
            textBox5.Text = "E - Mail :";
            // 
            // TxtEMail
            // 
            TxtEMail.Location = new Point(560, 164);
            TxtEMail.Name = "TxtEMail";
            TxtEMail.Size = new Size(128, 31);
            TxtEMail.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.DarkGray;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 10F);
            textBox7.Location = new Point(444, 243);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(75, 27);
            textBox7.TabIndex = 8;
            textBox7.Text = "Senha :";
            // 
            // TextSenha
            // 
            TextSenha.BorderStyle = BorderStyle.None;
            TextSenha.Location = new Point(516, 243);
            TextSenha.Name = "TextSenha";
            TextSenha.Size = new Size(179, 24);
            TextSenha.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.DarkGray;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI", 10F);
            textBox9.Location = new Point(295, 291);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(224, 27);
            textBox9.TabIndex = 10;
            textBox9.Text = "Confirmação de senha :";
            // 
            // TextConfirmacaoDeSenha
            // 
            TextConfirmacaoDeSenha.Location = new Point(526, 294);
            TextConfirmacaoDeSenha.Name = "TextConfirmacaoDeSenha";
            TextConfirmacaoDeSenha.Size = new Size(183, 31);
            TextConfirmacaoDeSenha.TabIndex = 11;
            // 
            // TxtPerfilDoUsuário
            // 
            TxtPerfilDoUsuário.BackColor = Color.DarkGray;
            TxtPerfilDoUsuário.Font = new Font("Segoe UI", 10F);
            TxtPerfilDoUsuário.Location = new Point(16, 223);
            TxtPerfilDoUsuário.Name = "TxtPerfilDoUsuário";
            TxtPerfilDoUsuário.Size = new Size(164, 34);
            TxtPerfilDoUsuário.TabIndex = 12;
            TxtPerfilDoUsuário.Text = "Perfil do Usuário :";
            // 
            // comboBoxPerfilDoUsuario
            // 
            comboBoxPerfilDoUsuario.FormattingEnabled = true;
            comboBoxPerfilDoUsuario.Items.AddRange(new object[] { "Programador", "Adiministrador", "Técnico", "Operador" });
            comboBoxPerfilDoUsuario.Location = new Point(206, 223);
            comboBoxPerfilDoUsuario.Name = "comboBoxPerfilDoUsuario";
            comboBoxPerfilDoUsuario.Size = new Size(182, 33);
            comboBoxPerfilDoUsuario.TabIndex = 13;
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxPerfilDoUsuario);
            Controls.Add(TxtPerfilDoUsuário);
            Controls.Add(TextConfirmacaoDeSenha);
            Controls.Add(textBox9);
            Controls.Add(TextSenha);
            Controls.Add(textBox7);
            Controls.Add(TxtEMail);
            Controls.Add(textBox5);
            Controls.Add(TxtNomeCompleto);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarioCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnSalvar;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnfechar;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox TxtNomeCompleto;
        private TextBox textBox5;
        private TextBox TxtEMail;
        private TextBox textBox7;
        private TextBox TextSenha;
        private TextBox textBox9;
        private TextBox TextConfirmacaoDeSenha;
        private TextBox TxtPerfilDoUsuário;
        private ComboBox comboBoxPerfilDoUsuario;
    }
}