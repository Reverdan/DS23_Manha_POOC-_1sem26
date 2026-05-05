using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplos.Modelo
{
    public class Primo : absPropriedades
    {

        public Primo(int numero) : base(numero)
        {
        }

        public override void Executar()
        {
            this.mensagem = "É primo";
            for (int i = 2; i < numero / 2 + 1; i++)
            {
                if (numero % i == 0)
                {
                    this.mensagem = "Não é primo";
                    break;
                }
                if (i > 3)
                {
                    if (i % 2 != 0)
                        i++;
                }
            }
        }
    }
}
