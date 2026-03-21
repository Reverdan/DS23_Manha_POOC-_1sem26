using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Validacao
    {
        private Double n1;
        private Double n2;
        private String num1;
        private String num2;
        private String op;
        private String mensagem;

        public Validacao(String num1, String num2, String op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            Validar();
        }

        private void Validar()
        {
            this.mensagem = "";
            try
            {
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                if (op.Equals("/") && n2 == 0.0)
                {
                    this.mensagem = "Não é possível dividir por zero.";
                }
            }
            catch (Exception e)
            {
                this.mensagem = "Digite números válidos";
            }
        }

        public double N1
        {
            get => n1;
        }
        public double N2
        {
            get => n2;
        }
        public String Mensagem
        {
            get => mensagem;
        }
    }
}
