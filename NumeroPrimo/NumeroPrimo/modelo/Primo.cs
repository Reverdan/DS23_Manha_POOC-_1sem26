using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPrimo.modelo
{
    public class Primo : absPropriedades
    {
        public Primo(int num)
        {
            this.num = num;
            this.Verificar();
        }

        private void Verificar()
        {
            this.mensagem = "É primo";
            for (int i = 2; i < num / 2 + 1; i++)
            {
                if (num % i == 0)
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
