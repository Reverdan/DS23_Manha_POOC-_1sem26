using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplos.Modelo
{
    public class Validacao : absPropriedades
    {

        public Validacao(string numero1) : base(numero1)
        {
            this.Validar(this.numero1);
        }

        public Validacao(string numero1, string numero2, string numero3) : base(numero1, numero2, numero3)
        {
            this.Validar(numero1, numero2, numero3);
        }

        public override void Executar()
        {
        }

        private void Validar(String numero1, String numero2, String numero3)
        {
            this.mensagem = "";
            try
            {
                this.lado1 = Convert.ToDouble(numero1);
                this.lado2 = Convert.ToDouble(numero2);
                this.lado3 = Convert.ToDouble(numero3);
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de conversão";
            }
        }

        private void Validar(String numero1)
        {
            this.mensagem = "";
            try
            {
                this.numero = Convert.ToInt32(numero1);
            }
            catch (Exception e)
            {
                this.mensagem = "Erro de conversão";
            }
        }
    }
}
