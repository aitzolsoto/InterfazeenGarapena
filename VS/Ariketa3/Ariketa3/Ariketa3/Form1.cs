namespace Ariketa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGorde_Click(object sender, EventArgs e)
        {
            if (radiobtnKontaktua.Checked)
            {
                KontaktuaSortu();
            }else if (radiobtnBezeroa.Checked)
            {
                BezeroaSortu();
            }else if (radiobtnLangilea.Checked)
            {
                LangileaSortu();
            }
        }

        private void KontaktuaSortu()
        {
            try
            {
                Kontaktua kontaktua = new Kontaktua();
                kontaktua.Izena = txtboxIzena.Text;
                kontaktua.Abizena = txtboxAbizena.Text;
                kontaktua.Nan = txtboxNan.Text;
                kontaktua.Emaila = txtboxEmail.Text;
                MessageBox.Show(kontaktua.Gorde());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BezeroaSortu()
        {
            try
            {
                Bezeroa bezeroa = new Bezeroa();
                bezeroa.Izena = txtboxIzena.Text;
                bezeroa.Abizena = txtboxAbizena.Text;
                bezeroa.Nan = txtboxNan.Text;
                bezeroa.Emaila = txtboxEmail.Text;
                bezeroa.Kategoria = comboboxKategoria.Text;
                MessageBox.Show(bezeroa.Gorde());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LangileaSortu()
        {
            try
            {
                Langilea langilea = new Langilea();
                langilea.Izena = txtboxIzena.Text;
                langilea.Abizena = txtboxAbizena.Text;
                langilea.Nan = txtboxNan.Text;
                langilea.Emaila = txtboxEmail.Text;
                langilea.Soldata = float.Parse(txtboxSoldata.Text);
                langilea.SegurtasunSoziala = txtboxSegurtasunSoziala.Text;
                MessageBox.Show(langilea.Gorde());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnIrten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}