namespace SenacFoods
{
    partial class FrnPrinncipal
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
            button1 = new Button();
            button2 = new Button();
            button6 = new Button();
            button3 = new Button();
            button5 = new Button();
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
            groupBox1.Location = new Point(116, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(26, 90);
            button1.Name = "button1";
            button1.Size = new Size(101, 97);
            button1.TabIndex = 0;
            button1.Text = "Cardápio";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(310, 90);
            button2.Name = "button2";
            button2.Size = new Size(101, 97);
            button2.TabIndex = 0;
            button2.Text = "Pedido da cozinha";
            button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Orange;
            button6.ForeColor = Color.Black;
            button6.Location = new Point(168, 90);
            button6.Name = "button6";
            button6.Size = new Size(101, 97);
            button6.TabIndex = 0;
            button6.Text = "Comanda";
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(455, 90);
            button3.Name = "button3";
            button3.Size = new Size(104, 97);
            button3.TabIndex = 0;
            button3.Text = "Usuários";
            button3.UseVisualStyleBackColor = false;
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
            // FrnPrinncipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(827, 432);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrnPrinncipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrnPrinncipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button5;
        private Button button3;
        private Button button6;
        private Button button2;
    }
}