using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplos.Modelo
{
    public class Fatorial : absPropriedades
    {
        public Fatorial(int numero) : base(numero)
        {
        }

        public override void Executar()
        {
            if (numero < 0) return;
            Int32 resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            this.mensagem = resultado.ToString();
        }
    }
}
