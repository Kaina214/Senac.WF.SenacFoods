namespace SenacFoods
{
    partial class FormCardápio
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
            groupBox1 = new GroupBox();
            btnAdicionar2 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btnEditar = new Button();
            btnExluir = new Button();
            label1 = new Label();
            btnfechar = new Button();
            panel1 = new Panel();
            textPesquisa = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdicionar2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(49, 67);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(750, 412);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardápio";
            // 
            // btnAdicionar2
            // 
            btnAdicionar2.BackColor = Color.Yellow;
            btnAdicionar2.Location = new Point(123, 23);
            btnAdicionar2.Margin = new Padding(4);
            btnAdicionar2.Name = "btnAdicionar2";
            btnAdicionar2.Size = new Size(146, 44);
            btnAdicionar2.TabIndex = 3;
            btnAdicionar2.Text = "+ Item";
            btnAdicionar2.UseVisualStyleBackColor = false;
            btnAdicionar2.Click += btnAdicionar;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(78, 70);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(836, 334);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
           
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 116);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(475, 39);
            textBox1.TabIndex = 4;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Green;
            btnEditar.Location = new Point(807, 480);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(146, 44);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExluir
            // 
            btnExluir.BackColor = Color.IndianRed;
            btnExluir.Location = new Point(653, 480);
            btnExluir.Margin = new Padding(4);
            btnExluir.Name = "btnExluir";
            btnExluir.Size = new Size(146, 44);
            btnExluir.TabIndex = 2;
            btnExluir.Text = "Excluir";
            btnExluir.UseVisualStyleBackColor = false;
            btnExluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar";
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
            btnfechar.Click += btnfechar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(textPesquisa);
            panel1.Controls.Add(btnfechar);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 73);
            panel1.TabIndex = 6;
            // 
            // textPesquisa
            // 
            textPesquisa.Location = new Point(141, 18);
            textPesquisa.Name = "textPesquisa";
            textPesquisa.Size = new Size(566, 39);
            textPesquisa.TabIndex = 4;
            textPesquisa.TextChanged += textPesquisa_TextChanged;
            // 
            // FormCardápio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(panel1);
            Controls.Add(btnExluir);
            Controls.Add(btnEditar);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormCardápio";
            Text = "FormCardápio";
            Load += FormCardápio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnExluir;
        private Label label1;
        private TextBox textBox1;
        private Button btnAdicionar2;
        private Button btnfechar;
        private Panel panel1;
        private TextBox textPesquisa;
    }
}