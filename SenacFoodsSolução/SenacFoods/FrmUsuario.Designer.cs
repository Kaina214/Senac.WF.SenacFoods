namespace SenacFoods
{
    partial class FrmUsuario
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
            BtnEditar = new Button();
            BtnExcluir = new Button();
            textBox1 = new TextBox();
            BtnAdicionar = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            TextUsuario = new TextBox();
            TextPesquisarUsuario = new TextBox();
            btnfechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.Red;
            BtnEditar.ForeColor = Color.Cornsilk;
            BtnEditar.Location = new Point(544, 395);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(112, 34);
            BtnEditar.TabIndex = 0;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnExcluir
            // 
            BtnExcluir.BackColor = Color.DarkGreen;
            BtnExcluir.Location = new Point(662, 395);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(112, 34);
            BtnExcluir.TabIndex = 1;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = false;
            BtnExcluir.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.BackColor = Color.Coral;
            BtnAdicionar.Location = new Point(426, 395);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(112, 34);
            BtnAdicionar.TabIndex = 3;
            BtnAdicionar.Text = "Add";
            BtnAdicionar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(142, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(543, 225);
            dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(btnfechar);
            panel1.Controls.Add(TextUsuario);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 85);
            panel1.TabIndex = 5;
            // 
            // TextUsuario
            // 
            TextUsuario.BackColor = Color.Green;
            TextUsuario.Font = new Font("Segoe UI", 13F);
            TextUsuario.ForeColor = SystemColors.ActiveCaptionText;
            TextUsuario.Location = new Point(45, 33);
            TextUsuario.Name = "TextUsuario";
            TextUsuario.Size = new Size(150, 42);
            TextUsuario.TabIndex = 0;
            TextUsuario.Text = "Usuário";
            // 
            // TextPesquisarUsuario
            // 
            TextPesquisarUsuario.Location = new Point(123, 109);
            TextPesquisarUsuario.Name = "TextPesquisarUsuario";
            TextPesquisarUsuario.Size = new Size(150, 31);
            TextPesquisarUsuario.TabIndex = 6;
            TextPesquisarUsuario.Text = "Pesquisar Usuário";
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Black;
            btnfechar.Font = new Font("Segoe UI", 11F);
            btnfechar.ForeColor = Color.White;
            btnfechar.Location = new Point(746, 3);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(55, 48);
            btnfechar.TabIndex = 7;
            btnfechar.Text = "X";
            btnfechar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextPesquisarUsuario);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(BtnAdicionar);
            Controls.Add(textBox1);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEditar;
        private Button BtnExcluir;
        private TextBox textBox1;
        private Button BtnAdicionar;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox TextUsuario;
        private TextBox TextPesquisarUsuario;
        private Button btnfechar;
    }
}