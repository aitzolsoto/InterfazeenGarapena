namespace Ariketa1
{
    public partial class Form1 : Form
    {
        Esaldia esaldia1 = new Esaldia();
        public Form1()
        {
            InitializeComponent();
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = false;
        }

        private void Hasieratu()
        {
            textEsaldia.Text = "";
            textEsaldia.Focus();
        }

        private void btnEsaldia(object sender, EventArgs e)
        {
            Button botoia = (Button)sender;

            if (!botoia.Name.Equals("btnLotu") && !textEsaldia.Text.Equals(""))
            {
                esaldia1.setEsaldiaBatuta(textEsaldia.Text);
            }else if (!botoia.Name.Equals("btnLotu") && textEsaldia.Text.Equals(""))
            {
                MessageBox.Show("Zerbait idatzi behar duzu");
                return;
            }
          
            switch (botoia.Name)
            {
                case "btnEsaldi1":
                    btnEsaldi1.Enabled = false;
                    btnEsaldi2.Enabled = true;
                    break;
                case "btnEsaldi2":
                    btnEsaldi2.Enabled = false;
                    btnEsaldi3.Enabled = true;
                    break;
                case "btnEsaldi3":
                    btnEsaldi3.Enabled = false;
                    btnEsaldi4.Enabled = true;
                    break;
                case "btnEsaldi4":
                    btnEsaldi4.Enabled = false;
                    btnEsaldi5.Enabled = true;
                    break;
                case "btnEsaldi5":
                    btnEsaldi5.Enabled = false;
                    btnLotu.Enabled = true;
                    textEsaldia.Enabled = false;
                    break;
                case "btnLotu":
                    MessageBox.Show(esaldia1.getEsaldiaBatuta());
                    break;
            }
            Hasieratu();
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            btnEsaldi1.Enabled = true;
            btnLotu.Enabled = false;
            textEsaldia.Enabled = true;
            esaldia1.EsaldiaEzabatu();
            textEsaldia.Focus();
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}