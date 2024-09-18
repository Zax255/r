namespace Modul2Aplikasi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalBelanja = int.Parse(textBox1.Text);
            int diskon = int.Parse(textBox2.Text);
            int diskonDapet = (int)((double)diskon / 100.0 * (double)totalBelanja);
            int sisaUang = totalBelanja - diskonDapet;
            label3.Text = sisaUang.ToString();
        } 

        
    }
}
