using System;
using System.Collections.Generic;
using System.Text;

namespace TemperaturaFC.modelo
{
    public class Conversao : absPropriedades
    {
        public Conversao(string tipo, double temperatura) : base(tipo, temperatura)
        {
        }

        public override void Executar()
        {
            if (this.tipo == "FC")
            {
                this.resposta = ((this.temperatura - 32) / 1.8).ToString("0.##");
            }
            else
            {
                this.resposta = ((this.temperatura * 1.8) + 32).ToString("0.##");
            }
        }

        public override string? ToString()
        {
            return resposta;
        }
    }
}
