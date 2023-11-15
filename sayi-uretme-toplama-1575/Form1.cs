using System.Windows.Forms;

namespace sayi_uretme_toplama_1575
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < lbSayilar.Items.Count; i++)
            {
                toplam += Convert.ToDouble(lbSayilar.Items[i]);
            }
            lblToplam.Text = "Toplam : " + toplam;
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int sayi, i;
            lbSayilar.Items.Clear();
            for (i = 0; i < 10; i++)
            {
                sayi = r.Next(0,20);
                lbSayilar.Items.Add(sayi);
            }
        }
    }
}