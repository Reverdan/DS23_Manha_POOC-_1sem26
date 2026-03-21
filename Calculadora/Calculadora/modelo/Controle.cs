using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Controle
    {
        private String num1;
        private String num2;
        private String op;
        private String mensagem;

        public Controle(String num1, String num2, String op)
        {
            this.num1 = num1.Replace(".", ",");
            this.num2 = num2.Replace(".", ",");
            this.op = op;
            Validar();
        }

        private void Validar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(num1, num2, op);
            if (validacao.Mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.N1, validacao.N2, op);
                this.mensagem = calculos.Resultado.ToString();
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public string Mensagem 
        { 
            get => mensagem; 
        }
    }
}
