namespace krediAPP
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Fuchsia;
            textBox1.Location = new Point(159, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Fuchsia;
            textBox2.Location = new Point(159, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Fuchsia;
            textBox3.Location = new Point(159, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Fuchsia;
            textBox4.Location = new Point(159, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Fuchsia;
            textBox5.Location = new Point(159, 216);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Fuchsia;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(159, 270);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 23);
            textBox6.TabIndex = 5;
            textBox6.Text = "BURAYI DOLDURMAYINIZ";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.DeepPink;
            checkBox1.Location = new Point(25, 39);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "KEFİLİM VAR.";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.DeepPink;
            checkBox2.Location = new Point(25, 70);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(97, 19);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "KEFİLİM YOK.";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Fuchsia;
            checkBox3.Location = new Point(25, 24);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(146, 19);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "%3 Faizli ihtiyaç kredisi";
            checkBox3.UseVisualStyleBackColor = false;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Fuchsia;
            checkBox4.Location = new Point(25, 67);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(133, 19);
            checkBox4.TabIndex = 9;
            checkBox4.Text = "%5 Faizli araç kredisi";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Fuchsia;
            checkBox5.Location = new Point(25, 111);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(148, 19);
            checkBox5.TabIndex = 10;
            checkBox5.Text = "%10 Faizli konut kredisi";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Location = new Point(492, 357);
            button1.Name = "button1";
            button1.Size = new Size(142, 59);
            button1.TabIndex = 11;
            button1.Text = "HESAPLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lime;
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(459, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(206, 124);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kefil Durumu";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Lime;
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Location = new Point(459, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 143);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kredi Türü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 14;
            label1.Text = "Adınız Soyadınız:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 84);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 15;
            label2.Text = "Maaş Miktarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 129);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 16;
            label3.Text = "Kredi Miktarı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 187);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 17;
            label4.Text = "Kefil Ad Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 224);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 18;
            label5.Text = "Maaş Miktarı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 278);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 19;
            label6.Text = "Aylık Faiz Tutarı:";
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.Location = new Point(35, 357);
            button2.Name = "button2";
            button2.Size = new Size(184, 59);
            button2.TabIndex = 20;
            button2.Text = "HESAPLAMA İŞLEMLERİ -->";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(721, 541);
            button3.Name = "button3";
            button3.Size = new Size(95, 47);
            button3.TabIndex = 21;
            button3.Text = "ÇIKIŞ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumTurquoise;
            button4.Location = new Point(35, 462);
            button4.Name = "button4";
            button4.Size = new Size(184, 51);
            button4.TabIndex = 22;
            button4.Text = "SÖZLEŞME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 128);
            button5.Location = new Point(494, 462);
            button5.Name = "button5";
            button5.Size = new Size(140, 55);
            button5.TabIndex = 23;
            button5.Text = "HESAPLAR";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(815, 589);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}