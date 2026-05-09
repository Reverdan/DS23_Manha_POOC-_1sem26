using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplos.Modelo
{
    public abstract class absPropriedades : IntMetodos
    {
        protected String numero1;
        protected String numero2;
        protected String numero3;
        protected Double lado1;
        protected Double lado2;
        protected Double lado3;
        protected Int32 numero;
        protected String resposta;

        protected String mensagem;

        protected absPropriedades(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.Executar();
        }

        protected absPropriedades(string numero1, string numero2, string numero3)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            this.numero3 = numero3;
            this.Executar();
        }

        protected absPropriedades(string numero1)
        {
            this.numero1 = numero1;
            this.Executar();
        }

        protected absPropriedades(int numero)
        {
            this.numero = numero;
            this.Executar();
        }

        protected absPropriedades()
        {
            this.Executar();
        }

        public String Mensagem
        {
            get { return mensagem; }
        }

        public Int32 Numero
        {
            get { return numero; }
        }

        public override string? ToString()
        {
            return this.mensagem;
        }

        public Double Lado1
        {
            get { return lado1; }
        }
        public Double Lado2
        {
            get { return lado2; }
        }
        public Double Lado3     
        {
            get { return lado3; }
        }


        public abstract void Executar();
    }
}
