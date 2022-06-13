using System;

namespace _004___100_Primeiros_numeros_impares_com_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = 1;

            while (Numero <= 100)
            {
                if ((Numero % 2) != 0)
                    Console.WriteLine(Numero);
                Numero++;
            }
        }
    }
}
