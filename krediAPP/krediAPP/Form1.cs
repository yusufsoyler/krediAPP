namespace krediAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslang�c = dateTimePicker1.Value;
            DateTime bitis = dateTimePicker2.Value;


            TimeSpan fark = bitis - baslang�c;
            int g�nFark� = (int)fark.TotalDays;

            label1.Text = "G�n Fark�: " + g�nFark�.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { //e�er date timerlar kullan�lmak istenirse bu �ekilde kullan�labilir

            /*  DateTime baslang�c = dateTimePicker1.Value;
              DateTime bitis = dateTimePicker2.Value;


              TimeSpan fark = bitis - baslang�c;
              int g�nFark� = (int)fark.TotalDays;

              if (g�nFark� < 30)
              {
                  label1.Text = "vade s�resi en az 1 ay olmal�d�r";

              }
              else
              { }
            */

            double anapara = Convert.ToDouble(textBox1.Text);
            double faizOrani = Convert.ToDouble(textBox2.Text) / 100;
            int vadeSuresi = Convert.ToInt32(textBox3.Text);


            double aylikFaizOrani = faizOrani / 12;
            double aylikOdeme = (anapara * aylikFaizOrani) / (1 - Math.Pow(1 + aylikFaizOrani, -vadeSuresi));
            double toplamOdeme = aylikOdeme * vadeSuresi;
            double toplamFaiz = toplamOdeme - anapara;

            //anapara * anapara * faiz /12

            label5.Text = "Ayl�k Taksit: " + aylikOdeme.ToString("C");
            label5.Text += "\nAnapara Miktar�:" + anapara.ToString();
            label5.Text += "\nToplam �deme: " + toplamOdeme.ToString("C");
            label5.Text += "\nToplam Faiz: " + toplamFaiz.ToString("C");
            label5.Text += "\nTaksit Say�s�: " + vadeSuresi.ToString();



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}