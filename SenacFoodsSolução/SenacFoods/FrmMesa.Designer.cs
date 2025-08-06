namespace SenacFoods
{
    partial class FrmMesa
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
            BtnAdicionarMesa = new Button();
            panel1 = new Panel();
            btnVoltar = new Button();
            textPesquisaMesa = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnEditar = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnAdicionarMesa
            // 
            BtnAdicionarMesa.BackColor = Color.Orange;
            BtnAdicionarMesa.Location = new Point(74, 7);
            BtnAdicionarMesa.Name = "BtnAdicionarMesa";
            BtnAdicionarMesa.Size = new Size(112, 45);
            BtnAdicionarMesa.TabIndex = 0;
            BtnAdicionarMesa.Text = "+ item";
            BtnAdicionarMesa.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(textPesquisaMesa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 95);
            panel1.TabIndex = 1;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Black;
            btnVoltar.Font = new Font("Segoe UI", 9F);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(725, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 40);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // textPesquisaMesa
            // 
            textPesquisaMesa.Font = new Font("Segoe UI", 12F);
            textPesquisaMesa.Location = new Point(141, 35);
            textPesquisaMesa.Name = "textPesquisaMesa";
            textPesquisaMesa.Size = new Size(569, 39);
            textPesquisaMesa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Crimson;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(BtnAdicionarMesa);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(0, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 358);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkGoldenrod;
            btnEditar.Location = new Point(676, 324);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Location = new Point(558, 324);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(658, 256);
            dataGridView1.TabIndex = 1;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesa";
            Text = "FrmMesa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdicionarMesa;
        private Panel panel1;
        private Label label1;
        private TextBox textPesquisaMesa;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnEditar;
        private Button btnVoltar;
    }
}