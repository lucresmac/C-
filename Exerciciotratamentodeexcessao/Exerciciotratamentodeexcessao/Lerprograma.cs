using System;
using System.Collections.Generic;
using System.Text;

namespace Exerciciotratamentodeexcessao
{
	public class Lerprograma
	{
		public void Lerarquivo()
		{
			var file =
			System.IO.File.Open(@"C:\Users\lucas\Desktop", System.IO.FileMode.Open);
			char[] Buffer = null;

			String str = new string(Buffer);
		}
		}
	public void EditarArquivo()
	{
		String path = @"C:\Users\lucas\Desktop";
		String novoTexto = Console.ReadLine();
		System.IO.File.WriteAllText(path, novoTexto);
	}



}
