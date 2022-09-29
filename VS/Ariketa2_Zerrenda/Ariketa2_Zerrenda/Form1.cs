namespace Ariketa2_Zerrenda
{
    public partial class Form1 : Form
    {
        private int zenbHurrengoa = 0;
        List<Ariketa_4> zenbakiak = new List<Ariketa_4>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (zenbHurrengoa)
            {
                case 0:
                    zenbakiak.Add(new Ariketa_4(double.Parse(textZenb.Text)));
                    labelZenbakia.Text = "2.Zenbakia";
                    break;
                case 1:
                    zenbakiak.Add(new Ariketa_4(double.Parse(textZenb.Text)));
                    labelZenbakia.Text = "3.Zenbakia";
                    break;
                case 2:
                    zenbakiak.Add(new Ariketa_4(double.Parse(textZenb.Text)));
                    labelZenbakia.Text = "4.Zenbakia";
                    break;
                case 3:
                    zenbakiak.Add(new Ariketa_4(double.Parse(textZenb.Text)));
                    labelZenbakia.Text = "Emaitza";
                    textZenb.Text = "(" + zenbakiak[0].zenbakia + " + (2 x " + zenbakiak[1].zenbakia + ") + (3 x " + zenbakiak[2].zenbakia + ") + (4 x " + zenbakiak[3].zenbakia + ")) / 4 = " + Ariketa_4.Eragiketa(zenbakiak); ;
                    btnHurrengoa.Enabled = false;
                    textZenb.Enabled = false;
                    break;
            }
            if (zenbHurrengoa < 3)
            {
                textZenb.Text = "";
                textZenb.Focus();
            }
            zenbHurrengoa++;
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            zenbHurrengoa = 0;
            textZenb.Text = "";
            textZenb.Enabled = true;
            labelZenbakia.Text = "1.Zenbakia";
            btnHurrengoa.Enabled = true;
            zenbakiak.Clear();
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}