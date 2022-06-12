using System;

namespace _006___Tabuada_com_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, Resultado, i = 0;
            Console.WriteLine("+------------------------------------------+");
            Console.WriteLine("INFORME UM NUMERO DA TABUADA QUE VOCÊ DESEJA");
            Console.WriteLine("+------------------------------------------+");
            Numero = int.Parse(Console.ReadLine());
            while (i < 11)
            {
                Resultado = (Numero * i);
                Console.WriteLine(Numero + " X " + i + " = " + Resultado);
                i++;
            }
        }
    }
}
