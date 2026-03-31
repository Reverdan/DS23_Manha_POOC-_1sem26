using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPrimo.modelo
{
    public class Controle : absPropriedades
    {
        public Controle(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        private void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.numero);
            if (validacao.mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.num);
                this.mensagem = primo.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
	}
}
