using System;

namespace _002___Media_do_aluno_recuperacao_com_if
{
    internal class Program
    {
        /*Faça um algoritmo que leia duas notas obtidas por um aluno na disciplina
         de Cálculo, o número de aulas assistidas por este aluno nesta disciplina. 
        Calcule e mostre a média final deste aluno e diga se ele foi aprovado ou 
        reprovado. Considere que para um aluno ser aprovado ele deve obter média 
       final igual ou maior a 6 e ter no mínimo 75% de frequência.*/
        static void Main(string[] args)
        {
            double Nota1, Nota2, TotaldeAulas, AulasAssistidas, Media, Frequencia;
            Console.WriteLine("+----------------------+");
            Console.WriteLine("INFORME A PRIMEIRO NOTA.");
            Console.WriteLine("+----------------------+");
            Nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("+---------------------+");
            Console.WriteLine("INFORME O SEGUNDA NOTA.");
            Console.WriteLine("+---------------------+");
            Nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("AULAS A QUANTIDADE DE AULAS QUE TEVE O CURSO.");
            Console.WriteLine("+-------------------------------------------+");
            TotaldeAulas = double.Parse(Console.ReadLine());

            Console.WriteLine("+--------------------------------------------------+");
            Console.WriteLine("INFORME A QUANTIDADE DE AULAS ASSISTIDAS PELO ALUNO.");
            Console.WriteLine("+--------------------------------------------------+");
            AulasAssistidas = double.Parse(Console.ReadLine());

            Media = (Nota1 + Nota2) / 2;
            Frequencia = (AulasAssistidas * 100) / (TotaldeAulas);

            if (Media >= 6 && Frequencia >= 75)
            {
                Console.WriteLine("+---------------------------------------------+");
                Console.WriteLine("ALUNO APROVADO COM NOTA " + Media + " E " + Frequencia + "% DE FREQUENCIA.");
                Console.WriteLine("+---------------------------------------------+");
            }
            else
            {
                Console.WriteLine("+---------------------------------------------+");
                Console.WriteLine("ALUNO REPROVADO COM NOTA " + Media + " E " + Frequencia + "% DE FREQUENCIA.");
                Console.WriteLine("+---------------------------------------------+");
            }
        }
    }
}
