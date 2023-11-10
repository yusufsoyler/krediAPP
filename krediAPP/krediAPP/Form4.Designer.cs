namespace krediAPP
{
    partial class Form4
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGreen;
            label1.Location = new Point(92, 52);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "TC KİMLİK:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleGreen;
            label2.Location = new Point(92, 92);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "İSİM SOYİSİM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PaleGreen;
            label3.Location = new Point(92, 132);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "İBAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleGreen;
            label4.Location = new Point(92, 172);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "PARA CİNSİ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.PaleGreen;
            label5.Location = new Point(92, 212);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 4;
            label5.Text = "HESAP BAKİYESİ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(294, 124);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "TR";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(294, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "TL", "USD", "EUP", "GBP", "KRON", "SAR" });
            comboBox1.Location = new Point(294, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Location = new Point(92, 271);
            button1.Name = "button1";
            button1.Size = new Size(411, 90);
            button1.TabIndex = 10;
            button1.Text = "GÖSTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(646, 340);
            button2.Name = "button2";
            button2.Size = new Size(91, 53);
            button2.TabIndex = 11;
            button2.Text = "ÇIKIŞ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Lime;
            label6.Location = new Point(465, 52);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Lime;
            label7.Location = new Point(465, 92);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 13;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Lime;
            label8.Location = new Point(465, 132);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 14;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Lime;
            label9.Location = new Point(465, 172);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 15;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(736, 393);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}