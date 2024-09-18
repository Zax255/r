namespace AsesmentModul2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mendapatkan nilai dari TextBox dan mengonversinya ke double
            double A = Convert.ToDouble(textBox1.Text);
            double B = Convert.ToDouble(textBox2.Text);
            double C = Convert.ToDouble(textBox3.Text);

            //Menghitung nilai D
            double D = Math.Pow(A/B, B*C);

            //Menampilkan hasil di label4
            label4.Text = "Nilai D:" + D.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
