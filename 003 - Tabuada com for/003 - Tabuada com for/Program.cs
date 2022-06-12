using System;

namespace _003___Tabuada_com_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, Resultado;
            Console.WriteLine("+------------------------------------------+");
            Console.WriteLine("INFORME UM NUMERO DA TABUADA QUE VOCÊ DESEJA");
            Console.WriteLine("+------------------------------------------+");
            Numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Resultado = (Numero * i);
                Console.WriteLine(Numero + " X " + i + " = " + Resultado);
            }
        }
    }
}
