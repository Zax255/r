namespace Modul2aplikasi2
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

        private void Hitung_Click(object sender, EventArgs e)
        {
            int sisi = int.Parse(txtsisi.Text);
            int volume = (int)Math.Pow((double)sisi, 3.0);
            txtvolume.Text = volume.ToString();
            lblvolume.Visible = true;
            txtvolume.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teks.Text = "";
            txtvolume.Visible = false;
            lblvolume.Visible = false;
        }

        private void txtsisi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
