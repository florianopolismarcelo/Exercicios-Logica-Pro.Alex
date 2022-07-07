using System;

namespace _017___Par_e_impar_com_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que peça N números inteiros, calcule e mostre a quantidade de números pares
            e a quantidade de números impares.*/

            int quantNumeros;
            int numero;
            int quantPares = 0, quantImpares = 0;

            Console.WriteLine("Quantidade de números: ");
            quantNumeros = int.Parse(Console.ReadLine());

            int count = 0;
            do
            {
                Console.WriteLine("Número: ");
                numero = int.Parse(Console.ReadLine());


                if (numero % 2 == 0) quantPares++;
                else quantImpares++;

                count++;
            } while (count < quantNumeros);

            Console.WriteLine("Quantidade Par: " + quantPares);
            Console.WriteLine("Quantidade Ímpar: " + quantImpares);
        }
    }
}