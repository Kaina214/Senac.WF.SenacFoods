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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            btnfechar = new Button();
            button3 = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(78, 70);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(836, 334);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(807, 480);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 1;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(653, 480);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(146, 44);
            button2.TabIndex = 2;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            textBox1.Location = new Point(105, 116);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(475, 39);
            textBox1.TabIndex = 4;
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
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(123, 23);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(146, 44);
            button3.TabIndex = 3;
            button3.Text = "+ Item";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnfechar);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 66);
            panel1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(566, 39);
            textBox2.TabIndex = 4;
            // 
            // FormCardápio
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Button btnfechar;
        private Panel panel1;
        private TextBox textBox2;
    }
}