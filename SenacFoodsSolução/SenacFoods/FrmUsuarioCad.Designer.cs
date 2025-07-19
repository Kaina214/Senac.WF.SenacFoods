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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnfechar = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.FloralWhite;
            button1.Location = new Point(555, 367);
            button1.Name = "button1";
            button1.Size = new Size(112, 37);
            button1.TabIndex = 0;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(673, 370);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = false;
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
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(176, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 24);
            textBox4.TabIndex = 5;
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
            // textBox6
            // 
            textBox6.Location = new Point(560, 164);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 31);
            textBox6.TabIndex = 7;
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
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(516, 243);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(179, 24);
            textBox8.TabIndex = 9;
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
            // textBox10
            // 
            textBox10.Location = new Point(526, 294);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(183, 31);
            textBox10.TabIndex = 11;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.DarkGray;
            textBox11.Font = new Font("Segoe UI", 10F);
            textBox11.Location = new Point(16, 223);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(164, 34);
            textBox11.TabIndex = 12;
            textBox11.Text = "Perfil do Usuário :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Programador", "Adiministrador", "Técnico", "Operador" });
            comboBox1.Location = new Point(206, 223);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 13;
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
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

        private Button button1;
        private Button button2;
        private Panel panel1;
        private TextBox textBox1;
        private Button btnfechar;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private ComboBox comboBox1;
    }
}