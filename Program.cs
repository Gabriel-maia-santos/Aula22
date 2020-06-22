using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Conversor.CotacaoDolar = 5.26f;
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("1 Dólar americano igual a 5,26 Real brasileiro");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("100 Dólares para Real:");
            Console.WriteLine("R$ " + Conversor.ConverterDolarParaReal(100));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("100 Reais para Dolar:");
            Console.WriteLine("US$ " + Conversor.ConverterRealparaDolar(100));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("100 Reais para Euro:");
            Console.WriteLine("EU$ " + Conversor.ConverterRealparaEuro(100));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("100 Euros para Real:");
            Console.WriteLine("R$ " + Conversor.ConverterEuroparaReal(100));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("100 Dólares para Euro:");
            Console.WriteLine("US$ " + Conversor.ConverterDolarParaEuro(100));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("100 Euros para Dolar:");
            Console.WriteLine("US$ " + Conversor.ConverterEuroParaDolar(100));
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.ResetColor();
        }
    }
}
