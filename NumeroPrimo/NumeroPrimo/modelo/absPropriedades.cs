using System;
using System.Collections.Generic;
using System.Text;

namespace NumeroPrimo.modelo
{
    public abstract class absPropriedades
    {
        private String mensagem;
        public String Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        private String numero;
        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        private int num;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }


    }
}
