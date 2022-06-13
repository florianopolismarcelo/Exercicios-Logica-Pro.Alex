using System;

namespace _009___Multiplos_de_5_com_intervalo_com_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (int i = 1; i <= 50; i++)
            {
                x = i;
                if (x % 2 != 0)
                    Console.WriteLine(x);
            }
        }
    }
}
