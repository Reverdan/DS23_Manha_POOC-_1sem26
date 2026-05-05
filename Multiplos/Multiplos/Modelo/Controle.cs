using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplos.Modelo
{
    public class Controle : absPropriedades
    {
        public Controle()
        {
        }

        public void CalcularFatorial(String numero1)
        {
            this.mensagem = "";
            absPropriedades validacao = new Validacao(numero1);
            if (validacao.ToString().Equals(""))
            {
                absPropriedades fatorial = new Fatorial(validacao.Numero);
                this.mensagem = fatorial.ToString();
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public void VerificarPrimo(String numero1)
        {

        }

        public void VerificarTriangulo(String numero1, String numero2, String numero3)
        {

        }

        public override void Executar()
        {
        }
    }
}
