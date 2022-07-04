using System;

namespace _016___Maior_numero_e_media_com_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia 5 números e informe o maior número e a média desses números.*/

            int numero;
            int maior = 0;
            int soma = 0;

            int count = 0;
            do
            {
                Console.WriteLine("Número: ");
                numero = int.Parse(Console.ReadLine());

                soma = soma + numero;

                if (numero > maior) maior = numero;

                count = count + 1;
            } while (count < 5);

            Console.WriteLine("Maior: " + maior);
            Console.WriteLine("Média: " + (soma / 5));
        }
    }
}