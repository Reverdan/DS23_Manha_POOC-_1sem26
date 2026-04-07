using System;
using System.Collections.Generic;
using System.Text;

namespace PrimoHeranca.modelo
{
    public abstract class absPropriedades
    {
		private String mensagem;
		private int num;
		private String numero;

        protected absPropriedades(int num)
        {
            this.num = num;
			this.Executar();
        }

        protected absPropriedades(string numero)
        {
            this.numero = numero;
			this.Executar();
        }

		protected virtual void Executar()
		{

		}


        public String Numero
		{
			get { return numero; }
			set { numero = value; }
		}


		public int Num
		{
			get { return num; }
			set { num = value; }
		}


		public String Mensagem
		{
			get { return mensagem; }
			set { mensagem = value; }
		}

	}
}
