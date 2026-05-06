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
            this.mensagem = "";
            absPropriedades validacao = new Validacao(numero1);
            if (validacao.ToString().Equals(""))
            {
                absPropriedades primo = new Primo(validacao.Numero);
                this.mensagem = primo.ToString();
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public void VerificarTriangulo(String numero1, String numero2, String numero3)
        {
            this.mensagem = "";
            absPropriedades validacao = new Validacao(numero1, numero2, numero3);
            if (validacao.ToString().Equals(""))
            {
                absPropriedades triangulo = new Triangulo(validacao.Lado1, validacao.Lado2, validacao.Lado3);
                this.mensagem = triangulo.ToString();
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public override void Executar()
        {
        }
    }
}
