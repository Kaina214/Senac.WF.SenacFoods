namespace SenacFoods
{
    partial class FrmMesaCad
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
            panel1 = new Panel();
            btnFechar2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textNumeroMesa = new TextBox();
            label2 = new Label();
            btnCancelarMesa = new Button();
            btnSalvarMesa = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(btnFechar2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 106);
            panel1.TabIndex = 0;
            // 
            // btnFechar2
            // 
            btnFechar2.BackColor = Color.Black;
            btnFechar2.Font = new Font("Segoe UI", 11F);
            btnFechar2.ForeColor = Color.White;
            btnFechar2.Location = new Point(759, 18);
            btnFechar2.Name = "btnFechar2";
            btnFechar2.Size = new Size(44, 44);
            btnFechar2.TabIndex = 7;
            btnFechar2.Text = "X";
            btnFechar2.UseVisualStyleBackColor = false;
            btnFechar2.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(174, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 37);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textNumeroMesa);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 288);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesa";
            // 
            // textNumeroMesa
            // 
            textNumeroMesa.Location = new Point(136, 71);
            textNumeroMesa.Name = "textNumeroMesa";
            textNumeroMesa.Size = new Size(374, 31);
            textNumeroMesa.TabIndex = 1;
            textNumeroMesa.Click += textNumeroMesa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 43);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 0;
            label2.Text = "Título";
            // 
            // btnCancelarMesa
            // 
            btnCancelarMesa.BackColor = Color.Goldenrod;
            btnCancelarMesa.Location = new Point(536, 486);
            btnCancelarMesa.Margin = new Padding(4);
            btnCancelarMesa.Name = "btnCancelarMesa";
            btnCancelarMesa.Size = new Size(146, 44);
            btnCancelarMesa.TabIndex = 6;
            btnCancelarMesa.Text = "x Cancelar";
            btnCancelarMesa.UseVisualStyleBackColor = false;
            // 
            // btnSalvarMesa
            // 
            btnSalvarMesa.BackColor = Color.DarkGreen;
            btnSalvarMesa.Location = new Point(690, 486);
            btnSalvarMesa.Margin = new Padding(4);
            btnSalvarMesa.Name = "btnSalvarMesa";
            btnSalvarMesa.Size = new Size(146, 44);
            btnSalvarMesa.TabIndex = 7;
            btnSalvarMesa.Text = "* Salvar";
            btnSalvarMesa.UseVisualStyleBackColor = false;
            btnSalvarMesa.Click += btnSalvar_Click;
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 543);
            Controls.Add(btnSalvarMesa);
            Controls.Add(btnCancelarMesa);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMesaCad";
            Text = "FrmMesaCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button btnFechar2;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textNumeroMesa;
        private Button btnCancelarMesa;
        private Button btnSalvarMesa;
    }
}