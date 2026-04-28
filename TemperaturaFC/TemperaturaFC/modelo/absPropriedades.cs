using System;
using System.Collections.Generic;
using System.Text;

namespace TemperaturaFC.modelo
{
    public abstract class absPropriedades : intMetodos
    {
        protected String mensagem;

        public String Mensagem
        {
            get { return mensagem; }
        }

        protected String resposta;

        //public String Resposta
        //{
        //    get { return resposta; }
        //}

        protected String temp;
        protected Double temperatura;

        public Double Temperatura
        {
            get { return temperatura; }
        }

        protected String tipo;

        protected absPropriedades(string temp)
        {
            this.temp = temp;
            this.Executar();
        }

        protected absPropriedades(string tipo, double temperatura)
        {
            this.tipo = tipo;
            this.temperatura = temperatura;
            this.Executar();
        }

        protected absPropriedades(string tipo, string temp)
        {
            this.tipo = tipo;
            this.temp = temp;
            this.Executar();
        }

        public abstract void Executar();

        
    }
}
