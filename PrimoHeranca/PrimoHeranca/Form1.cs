using PrimoHeranca.modelo;

namespace PrimoHeranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero.Text);
            lblResultado.Text = controle.Mensagem;
        }
    }
}
