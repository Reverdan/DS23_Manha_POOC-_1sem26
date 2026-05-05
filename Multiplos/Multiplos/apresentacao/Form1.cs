using Multiplos.apresentacao;

namespace Multiplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmPrimo_Click(object sender, EventArgs e)
        {
            frmPrimo frmP = new frmPrimo();
            this.Visible = false;
            frmP.ShowDialog();
            this.Visible = true;

        }

        private void tsmTriangulos_Click(object sender, EventArgs e)
        {
            frmTriangulos frmT = new frmTriangulos();
            frmT.ShowDialog();
        }

        private void tsmFatorial_Click(object sender, EventArgs e)
        {
            frmFatorial frmF = new frmFatorial();
            frmF.ShowDialog();
        }

    }
}
