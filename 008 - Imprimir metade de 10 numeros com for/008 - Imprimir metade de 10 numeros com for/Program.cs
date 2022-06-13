using System;

namespace _008___Imprimir_metade_de_10_numeros_com_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (int i = 1; i <= 10; i++)
            {
                x = i;
                if (x % 2 != 0)
                    Console.WriteLine(x);
            }
        }
    }
}
