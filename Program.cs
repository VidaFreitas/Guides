using System;

namespace Guides
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Este texto é um teste";
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("O texto é um teste"));
            Console.WriteLine(texto.Equals("Este texto é um Teste"));
        }
    }
}
