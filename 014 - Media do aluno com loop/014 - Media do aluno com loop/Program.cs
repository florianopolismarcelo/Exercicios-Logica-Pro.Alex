using System;

namespace _014___Media_do_aluno_com_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que leia conjuntos de dois valores,
            o primeiro representando o nome do aluno e o segundo representando a sua idade.
            (Pare o programa inserindo o valor 0 no campo nome) */

            String nome;
            int idade;

            while (true)
            {
                Console.WriteLine("Infome o nome do aluno");
                nome = Console.ReadLine();

                if ( nome == "0") 
                break;
            }

            Console.WriteLine("Infome a idade do aluno");
            idade = int.Parse(Console.ReadLine());
        }
    }
}
