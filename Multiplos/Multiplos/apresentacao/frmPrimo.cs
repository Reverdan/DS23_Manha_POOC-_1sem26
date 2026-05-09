using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Multiplos.Modelo;

namespace Multiplos.apresentacao
{
    public partial class frmPrimo : Form
    {
        public frmPrimo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.VerificarPrimo(txbPrimo.Text);
            lblResposta.Text = controle.ToString();
        }
    }
}
