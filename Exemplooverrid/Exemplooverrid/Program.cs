using System;

namespace Exemplooverrid
{
	class programa
	{
		static void Main(string[] args)
		{

			Pessoa p = new Pessoa();
			Homem h = new Homem();
			Mulher m = new Mulher();

			p.falar();
			h.falar();
			m.falar();
			Pessoa p2 = new Homem();
			Pessoa p3 = new Mulher();
			p2.falar();
			p3.falar();
			Pessoa p4 = CriarPessoa();
			p4.falar();
			p4.Nome = "Lucima";
			Console.Write("ToString():");
			Console.WriteLine(p4.ToString());

			Console.ReadKey();


		}

		private static Pessoa CriarPessoa()
		{
			Random r = new Random();
			if (r.Next(10) < 5)
			{
				return new Homem();
			}
			else
			{
				return new Mulher();
			}
		}
	}
}
