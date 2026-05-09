using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplos.Modelo
{
    public class Triangulo : absPropriedades
    {
        public Triangulo(double lado1, double lado2, double lado3) : base(lado1, lado2, lado3)
        {
        }

        public override void Executar()
        {
            if (this.lado1.Equals(this.lado2) &&
                this.lado1.Equals(this.lado3))
            {
                this.resposta = "Triângulo equilátero";
            }
            else
            {
                if (!this.lado1.Equals(this.lado2) &&
                        !this.lado1.Equals(this.lado3) &&
                        !this.lado2.Equals(this.lado3))
                {
                    this.resposta = "Triângulo Escaleno";
                }
                else
                {
                    this.resposta = "Triângulo Isósceles";
                }
            }
            this.mensagem = this.resposta;
        }
    }
}
