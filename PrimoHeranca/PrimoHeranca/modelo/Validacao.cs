using System;
using System.Collections.Generic;
using System.Text;

namespace PrimoHeranca.modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao(string numero) : base(numero)
        {
        }

        protected override void Executar()
        {
            this.Mensagem = "";
            try
            {
                this.Num = Convert.ToInt32(this.Numero);
            }
            catch (Exception e)
            {
                this.Mensagem = "Conversão inválida";
            }

        }
    }
}
