using System;

namespace _005___Tabuada_com_2_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int m = 1; m <= 10; m++)

            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine(m + " X " + a + " = " + m * a);
                }
                Console.WriteLine();
            }
        }
    }
}
