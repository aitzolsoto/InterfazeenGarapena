namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkulagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEragiketa(object sender, EventArgs e)
        {
            Button botoia = (Button)sender;
            try
            {
                kalkulagailua.Zenbaki1 = float.Parse(textZenb1.Text);
                kalkulagailua.Zenbaki2 = float.Parse(textZenb2.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

            switch (botoia.Name)
            {
                case "btnGehitu":
                    MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00"));
                    break;
                case "btnKen":
                    MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"));
                    break;
                case "btnBidertu":
                    MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"));
                    break;
                case "btnZatitu":
                    MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"));
                    break;
            }
            Hasieratu();
        }

        private bool Balioak()
        {
            try
            {
                kalkulagailua.Zenbaki1 = float.Parse(textZenb1.Text);
                kalkulagailua.Zenbaki2 = float.Parse(textZenb2.Text);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;

        }

        private void Hasieratu()
        {
            textZenb1.Text = "";
            textZenb2.Text = "";
            textZenb1.Focus();
        }

        private void btnGehitu_Click(object sender, EventArgs e)
        {
            /*if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00"));
                Hasieratu();
            }*/
        }

        private void btnKen_Click(object sender, EventArgs e)
        {
            /*if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"));
                 Hasieratu();
            }*/
        }

        private void btnBidertu_Click(object sender, EventArgs e)
        {
            /*if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"));
                Hasieratu();
            }*/
        }

        private void btnZatitu_Click(object sender, EventArgs e)
        {
            /*if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"));
                Hasieratu();
            }*/
        }



        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textZenb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                 && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera 
                 && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                 && e.KeyChar != Convert.ToChar(",")) // ez bada koma
{
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (textZenb1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (textZenb1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }

        private void textZenb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                 && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera 
                 && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                 && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (textZenb2.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (textZenb2.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
    }
}