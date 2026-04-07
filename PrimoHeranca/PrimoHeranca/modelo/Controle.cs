using System;
using System.Collections.Generic;
using System.Text;

namespace PrimoHeranca.modelo
{
    public class Controle : absPropriedades
    {
        public Controle(string numero) : base(numero)
        {
        }

        protected override void Executar()
        {
            this.Mensagem = "";
            Validacao validacao = new Validacao(this.Numero);
            if (validacao.Mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.Num);
                this.Mensagem = primo.Mensagem;
            }
            else
            {
                this.Mensagem = validacao.Mensagem;
            }
        }
    }
}
