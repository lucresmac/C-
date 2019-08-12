using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplooverrid
{
	public class Mulher : Pessoa
	{

		public override void falar()
		{
			Console.WriteLine("Mulher fala!");
			base.falar();
		}
	}
}
