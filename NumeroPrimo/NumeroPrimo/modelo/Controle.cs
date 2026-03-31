using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPrimo.modelo
{
    public class Controle
    {
		private String mensagem;
		private String numero;

        public Controle(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        private void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.numero);
            if (validacao.Mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.N1);
                this.mensagem = primo.Mensagem;
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public String Mensagem
		{
			get { return mensagem; }
		}

	}
}
