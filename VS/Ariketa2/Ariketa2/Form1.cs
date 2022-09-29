namespace Ariketa2
{
    public partial class Form1 : Form
    {
        private int zenbHurrengoa = 0;
        private Eragiketa eragiketa;
        public Form1()
        {
            InitializeComponent();
            eragiketa = new Eragiketa();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHurrengoa_Click(object sender, EventArgs e)
        {
            switch (zenbHurrengoa)
            {
                case 0:
                    eragiketa.a = float.Parse(textZenb.Text);
                    labelZenbakia.Text = "2.Zenbakia";
                    break;
                case 1:
                    eragiketa.b = float.Parse(textZenb.Text);
                    labelZenbakia.Text = "3.Zenbakia";
                    break;
                case 2:
                    eragiketa.c = float.Parse(textZenb.Text);
                    labelZenbakia.Text = "4.Zenbakia";
                    break;
                case 3:
                    eragiketa.d = float.Parse(textZenb.Text);
                    labelZenbakia.Text = "Emaitza";
                    textZenb.Text = eragiketa.eragiketaErakutsi();
                    btnHurrengoa.Enabled = false;
                    textZenb.Enabled = false;
                    break;
            }
            if(zenbHurrengoa < 3)
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
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}