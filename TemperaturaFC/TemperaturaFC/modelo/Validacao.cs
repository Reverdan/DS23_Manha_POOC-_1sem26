using System;
using System.Collections.Generic;
using System.Text;

namespace TemperaturaFC.modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao(string temp) : base(temp)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.temperatura = Convert.ToDouble(this.temp);
            }
            catch(Exception e)
            {
                this.mensagem = "Digite valores válidos";
            }
        }
    }
}
