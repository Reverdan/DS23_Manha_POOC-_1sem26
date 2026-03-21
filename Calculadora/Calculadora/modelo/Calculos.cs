using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Calculos
    {
		private Double n1;
		private Double n2;
		private String op;
		private Double resultado;

        public Calculos(double n1, double n2, string op)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
			Calcular();
        }

		private void Calcular()
		{
			if (op.Equals("+"))
				resultado = n1 + n2;
			if (op.Equals("-"))
				resultado = n1 - n2;
			if (op.Equals("*"))
				resultado = n1 * n2;
			if (op.Equals("/"))
				resultado = n1 / n2;
        }

        public Double Resultado
		{
			get { return resultado; }
		}
	}
}
