using System;

namespace _004___100_Primeiros_numeros_impares_com_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (int i = 1; i <= 100; i++)
            {
                x = i;
                if (x % 2 != 0)
                    Console.WriteLine(x);
            }
        }
    }
}
