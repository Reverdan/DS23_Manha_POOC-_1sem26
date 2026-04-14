using System;
using System.Collections.Generic;
using System.Text;

namespace TemperaturaFC.modelo
{
    public class Controle : absPropriedades
    {
        public Controle(string tipo, string temp) : base(tipo, temp)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.temp);
            if (validacao.Mensagem.Equals(""))
            {
                Conversao conversao = new Conversao(this.tipo, validacao.Temperatura);
                this.resposta = conversao.Resposta;
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }
    }
}
