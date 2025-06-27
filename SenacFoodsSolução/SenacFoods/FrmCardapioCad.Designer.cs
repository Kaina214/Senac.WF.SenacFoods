namespace SenacFoods
{
    partial class FrmCardapioCad
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
            panel1 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            btnfechar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtPreço = new TextBox();
            txtDescricao = new RichTextBox();
            txtTitulo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            chkPossuiPreparo = new CheckBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnfechar);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 77);
            panel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(758, 7);
            button1.Name = "button1";
            button1.Size = new Size(44, 44);
            button1.TabIndex = 6;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(566, 31);
            textBox2.TabIndex = 4;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Black;
            btnfechar.Font = new Font("Segoe UI", 11F);
            btnfechar.ForeColor = Color.White;
            btnfechar.Location = new Point(973, 8);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(55, 48);
            btnfechar.TabIndex = 5;
            btnfechar.Text = "X";
            btnfechar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(2, 82);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(798, 355);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPreço);
            groupBox2.Controls.Add(txtDescricao);
            groupBox2.Controls.Add(txtTitulo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(-4, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(795, 371);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cardapio";
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(109, 324);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(468, 31);
            txtPreço.TabIndex = 10;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(109, 185);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(468, 92);
            txtDescricao.TabIndex = 11;
            txtDescricao.Text = "";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(94, 94);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(483, 31);
            txtTitulo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 280);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 9;
            label4.Text = "Preço";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 138);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 8;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 50);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 7;
            label2.Text = "Titulo";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Goldenrod;
            btnCancelar.Location = new Point(500, 510);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 44);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "x Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.DarkGreen;
            btnSalvar.Location = new Point(654, 510);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(146, 44);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "* Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(79, 482);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(163, 29);
            chkPossuiPreparo.TabIndex = 10;
            chkPossuiPreparo.Text = "Possui Preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 582);
            Controls.Add(chkPossuiPreparo);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(btnSalvar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox2;
        private Button btnfechar;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSalvar;
        private Button btnCancelar;
        private RichTextBox txtDescricao;
        private TextBox txtTitulo;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPreço;
        private CheckBox chkPossuiPreparo;
    }
}