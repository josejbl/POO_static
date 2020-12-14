using System;

namespace POO_static
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Conversao de Dolar e Real");
              Console.WriteLine(Conversor.DolarParaReais(145));

              Console.WriteLine(Conversor.RealParaDolar(149));
                 

              Console.WriteLine("Conversao de Euro e Real");
              Console.WriteLine(Conversor.EuroParaReais(345));

              Console.WriteLine(Conversor.RealParaEuro(674));
              Console.WriteLine("Conversao de Euro e Real");
        }
    }
}
