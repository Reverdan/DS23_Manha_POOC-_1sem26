using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPrimo.modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao(string numero)
        {
            this.Numero = numero;
			this.Validar();
        }

		private void Validar()
		{
			this.Mensagem = "";
			try
			{
				this.Num = Convert.ToInt32(this.Numero);
			}
			catch (Exception e)
			{
				this.Mensagem = "Conversão inválida";
			}
		}
	}
}
