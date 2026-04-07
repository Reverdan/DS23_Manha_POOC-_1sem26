using System;
using System.Collections.Generic;
using System.Text;

namespace PrimoHeranca.modelo
{
    public class Primo : absPropriedades
    {
        public Primo(int num) : base(num)
        {
        }

        protected override void Executar()
        {
            this.Mensagem = "É primo";
            for (int i = 2; i < Num / 2 + 1; i++)
            {
                if (Num % i == 0)
                {
                    this.Mensagem = "Não é primo";
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
