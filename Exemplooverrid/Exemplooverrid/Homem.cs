using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplooverrid
{
	public class Homem : Pessoa
	{

		public override void falar()
		{
			Console.WriteLine("Homem Fala!");
		}
	}
}
