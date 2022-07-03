using System;

namespace _015___Nota_com_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que peça uma nota, entre zero e dez.
            Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido. */


            int nota;

            Console.WriteLine("Informe a nota do aluno");
            nota = int.Parse(Console.ReadLine());

            while (nota < 0 | nota > 10)
            {
                Console.WriteLine("Nota Inválida! Digite novamente: ");
                break;
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Você digitou a nota: " +nota);
            Console.WriteLine("-----------------------");

        }
    }
}