// See https://aka.ms/new-console-template for more information

using Numeros_primos;
using System;

namespace Numeros_primos
{
    internal class Program
    {
        static void Main(string[] args)

        {

            for (int i = 2; i <= 100; i++)
            {
                if (ehPrimo(i))
                    Console.WriteLine(i + " é primo.");
            }
        }
        private static bool ehPrimo(int numero)

        {
            for (int j = 2; j < numero; j++)
            {
                if (numero % j == 0)
                    return false;
            }
            return true;
        }
    }
}
