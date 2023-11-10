using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krediAPP
{
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textBoxValue1 = textBox1.Text;
            string textBoxValue2 = textBox2.Text;
            string textBoxValue3 = textBox3.Text;
            string textBoxValue4 = textBox4.Text;
            string comboBoxValue = comboBox1.Text;
            string result1 = $"TC: {textBoxValue1}";
            string result2 = $"İSİM SOYİSİM: {textBoxValue2}";
            string result3 = $"İBAN: {textBoxValue3}";
            string result4 = $"PARA MİKTARI: {textBoxValue4},DÖVİZ CİNSİ: {comboBoxValue}";

            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            label6.Text = result1;
            label7.Text = result2;
            label8.Text = result3;
            label9.Text = result4;

        }
    }
}
