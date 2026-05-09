using Multiplos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Multiplos.apresentacao
{
    public partial class frmFatorial : Form
    {
        public frmFatorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.CalcularFatorial(txbFatorial.Text);
            lblResposta.Text = controle.ToString();
        }
    }
}
