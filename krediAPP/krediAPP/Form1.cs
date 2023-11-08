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
            DateTime baslangýc = dateTimePicker1.Value;
            DateTime bitis = dateTimePicker2.Value;


            TimeSpan fark = bitis - baslangýc;
            int günFarký = (int)fark.TotalDays;

            label1.Text = "Gün Farký: " + günFarký.ToString();

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
        { //eðer date timerlar kullanýlmak istenirse bu þekilde kullanýlabilir

            /*  DateTime baslangýc = dateTimePicker1.Value;
              DateTime bitis = dateTimePicker2.Value;


              TimeSpan fark = bitis - baslangýc;
              int günFarký = (int)fark.TotalDays;

              if (günFarký < 30)
              {
                  label1.Text = "vade süresi en az 1 ay olmalýdýr";

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

            label5.Text = "Aylýk Taksit: " + aylikOdeme.ToString("C");
            label5.Text += "\nAnapara Miktarý:" + anapara.ToString();
            label5.Text += "\nToplam Ödeme: " + toplamOdeme.ToString("C");
            label5.Text += "\nToplam Faiz: " + toplamFaiz.ToString("C");
            label5.Text += "\nTaksit Sayýsý: " + vadeSuresi.ToString();



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