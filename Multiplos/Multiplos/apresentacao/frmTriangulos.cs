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
    public partial class frmTriangulos : Form
    {
        public frmTriangulos()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.VerificarTriangulo(txbLado1.Text, txbLado2.Text, txbLado3.Text);
            lblResposta.Text = controle.ToString();
        }
    }
}
