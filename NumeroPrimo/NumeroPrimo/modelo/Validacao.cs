using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPrimo.modelo
{
    public class Validacao : absPropriedades
    {
		

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
				this.num = Convert.ToInt32(this.numero);
			}
			catch (Exception e)
			{
				this.mensagem = "Conversão inválida";
			}
		}
	}
}
