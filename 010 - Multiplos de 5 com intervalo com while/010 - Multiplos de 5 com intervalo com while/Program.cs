using System;

namespace _010___Multiplos_de_5_com_intervalo_com_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, Resultado;
            while (i <= 50)
            {
                Resultado = (i * 5);
                Console.WriteLine(Resultado);
                i++;
            }
        }
    }
}
