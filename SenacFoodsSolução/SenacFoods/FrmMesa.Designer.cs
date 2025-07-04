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
            btnAdicionarMesa = new Button();
            panel1 = new Panel();
            btnfechar = new Button();
            textPesquisaMesa = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionarMesa
            // 
            btnAdicionarMesa.BackColor = Color.Orange;
            btnAdicionarMesa.Location = new Point(74, 7);
            btnAdicionarMesa.Name = "btnAdicionarMesa";
            btnAdicionarMesa.Size = new Size(112, 45);
            btnAdicionarMesa.TabIndex = 0;
            btnAdicionarMesa.Text = "+ item";
            btnAdicionarMesa.UseVisualStyleBackColor = false;
            btnAdicionarMesa.Click += btnAdicionarMesa_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(btnfechar);
            panel1.Controls.Add(textPesquisaMesa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 95);
            panel1.TabIndex = 1;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Black;
            btnfechar.Font = new Font("Segoe UI", 11F);
            btnfechar.ForeColor = Color.White;
            btnfechar.Location = new Point(733, 13);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(55, 48);
            btnfechar.TabIndex = 6;
            btnfechar.Text = "X";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
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
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnAdicionarMesa);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(0, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 358);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGoldenrod;
            button2.Location = new Point(676, 324);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
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
            ClientSize = new Size(800, 450);
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

        private Button btnAdicionarMesa;
        private Panel panel1;
        private Label label1;
        private TextBox textPesquisaMesa;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button btnfechar;
    }
}