using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPrimo.modelo
{
    public class Validacao
    {
		private String mensagem;
		private int n1;
		private String numero;

        public Validacao(string numero)
        {
            this.numero = numero;
			this.Validar();
        }

		private void Validar()
		{
			this.mensagem = "";
			try
			{
				this.n1 = Convert.ToInt32(this.numero);
			}
			catch (Exception e)
			{
				this.mensagem = "Conversão inválida";
			}
		}

        public int N1
		{
			get { return n1; }
		}

		public String Mensagem
		{
			get { return mensagem; }
		}

	}
}
