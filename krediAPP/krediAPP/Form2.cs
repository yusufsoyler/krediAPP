using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace krediAPP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Lütfen kefil bilgilerini giriniz.");
                groupBox2.Visible = true;
            }
            else
                groupBox2.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            MessageBox.Show("Bankamız kefil olmadan kredi verememektedir. pis fakir:)");
            checkBox2.Visible = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int maas, maas1;
            maas = int.Parse(textBox2.Text);
            maas1 = int.Parse(textBox5.Text);

            if (maas <= 7500)
            {
                MessageBox.Show("Bankamız maas miktarınız 7500 TL az olduğu için kredi vermemektedir.:)");
            }
            if (maas1 <= 7500)
            {
                MessageBox.Show("Bankamız kefiliniz maaş miktarının 7500 TL az olduğu için kredi vermemektedir. :)");
            }

            double sayi1, tutar;
            sayi1 = double.Parse(textBox3.Text);

            if (checkBox3.Checked == true)
            {
                tutar = ((sayi1 * 3 / 100) / 12);
                textBox6.Text = tutar.ToString();
            }

            if (checkBox4.Checked == true)
            {
                tutar = ((sayi1 * 5 / 100) / 12);
                textBox6.Text = tutar.ToString();
            }

            if (checkBox5.Checked == true)
            {
                tutar = ((sayi1 * 10 / 100) / 12);
                textBox6.Text = tutar.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

