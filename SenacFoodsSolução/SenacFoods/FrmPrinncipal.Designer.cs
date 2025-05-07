namespace SenacFoods
{
    partial class FrmPrinncipal
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
            button5 = new Button();
            button3 = new Button();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnfechar = new Button();
            button4 = new Button();
            lblMensagem = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(78, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(711, 90);
            button5.Name = "button5";
            button5.Size = new Size(92, 97);
            button5.TabIndex = 3;
            button5.Text = "Usuários";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Font = new Font("Segoe UI", 13F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(484, 80);
            button3.Name = "button3";
            button3.Size = new Size(127, 119);
            button3.TabIndex = 0;
            button3.Text = "Usuários";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnusuarios;
            // 
            // button6
            // 
            button6.BackColor = Color.Orange;
            button6.Font = new Font("Segoe UI", 13F);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(196, 80);
            button6.Name = "button6";
            button6.Size = new Size(120, 119);
            button6.TabIndex = 0;
            button6.Text = "Comanda";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btncomanda;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI", 13F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(332, 80);
            button2.Name = "button2";
            button2.Size = new Size(121, 119);
            button2.TabIndex = 0;
            button2.Text = "Pedido da cozinha";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnpedidodacozinha;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 13F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(26, 80);
            button1.Name = "button1";
            button1.Size = new Size(136, 119);
            button1.TabIndex = 0;
            button1.Text = "Cardápio";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnfechar
            // 
            btnfechar.BackColor = Color.Black;
            btnfechar.Font = new Font("Segoe UI", 11F);
            btnfechar.ForeColor = Color.White;
            btnfechar.Location = new Point(758, 2);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(74, 34);
            btnfechar.TabIndex = 1;
            btnfechar.Text = "X";
            btnfechar.UseVisualStyleBackColor = false;
            btnfechar.Click += btnfechar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Segoe UI", 14F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(678, 2);
            button4.Name = "button4";
            button4.Size = new Size(74, 43);
            button4.TabIndex = 2;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 16F);
            lblMensagem.ForeColor = Color.White;
            lblMensagem.Location = new Point(239, 24);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(213, 45);
            lblMensagem.TabIndex = 3;
            lblMensagem.Text = "lblMensagem";
            // 
            // FrmPrinncipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(827, 432);
            Controls.Add(lblMensagem);
            Controls.Add(button4);
            Controls.Add(btnfechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrinncipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrnPrinncipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button5;
        private Button button3;
        private Button button6;
        private Button button2;
        private Button btnfechar;
        private Button button4;
        private Label lblMensagem;
    }
}