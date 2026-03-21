using Calculadora.modelo;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Executar(String op)
        {
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, op);
            lblResultado.Text = controle.Mensagem;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            this.Executar("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            this.Executar("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            this.Executar("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            this.Executar("/");
        }
    }
}
