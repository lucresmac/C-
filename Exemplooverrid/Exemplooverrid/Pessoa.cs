using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplooverrid
{
	public class Pessoa
	{
		public String Nome { get; set; }

		public virtual void falar()
		{
			Console.WriteLine("Pessoa fala!");
		}

		public virtual void falar(String Mensagem)
		{
			Console.WriteLine("Uma Pessoa fala!");
		}

		public override string ToString()
		{
			return this.Nome;
		}
	}

}
