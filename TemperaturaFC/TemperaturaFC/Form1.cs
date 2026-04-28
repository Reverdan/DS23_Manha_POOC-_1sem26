using TemperaturaFC.modelo;

namespace TemperaturaFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brnCalcular_Click(object sender, EventArgs e)
        {
            Controle controle;
            if (rdbCF.Checked)
            {
                controle = new Controle("CF", txbTemperatura.Text.Replace(".", ","));
                lblResultado.Text = controle.ToString();
            }
            else
            {
                controle = new Controle("FC", txbTemperatura.Text.Replace(".", ","));
                lblResultado.Text = controle.ToString();
            }
        }
    }
}
