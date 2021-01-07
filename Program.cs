using System;

namespace Guides
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Esse texto é um teste";
            Console.WriteLine(texto.Contains("Teste"));
            Console.WriteLine(texto.Contains("teste"));
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
        }
    }
}
