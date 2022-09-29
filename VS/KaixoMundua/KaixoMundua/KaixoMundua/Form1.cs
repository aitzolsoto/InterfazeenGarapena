namespace KaixoMundua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntKaixo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaixo mundua");
        }

        private void btnItxi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}