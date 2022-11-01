// See https://aka.ms/new-console-template for more information

/*Faça um Programa que peça as quatro notas de 10 alunos, calcule e armazene num vetor a média 
de cada aluno, imprima o número de alunos com média maior ou igual a 7.0.*/


double[] vetorNotaAluno = new double[4];
double[] vetorMediaAluno = new double[2];

double nota = 0, media = 0;

int n = 0, i = 0;

Console.WriteLine("---------------");
Console.WriteLine("Notas do Aluno: ");
Console.WriteLine("---------------");

for (i = 0; i <=3; i++)
{
    for (n = 0; n < 4; n++)
    {
        //Console.Clear();
        Console.WriteLine("Digite a nota: ");
        nota = Convert.ToInt32(Console.ReadLine());
        vetorNotaAluno[n] = nota;

        media = vetorNotaAluno[0] + vetorNotaAluno[1] + vetorNotaAluno[2] + vetorNotaAluno[3];
        media = media / 4;
        vetorMediaAluno[i] = media;
        media = media + 1;
    }
    if (media >= 7)
    {
        vetorMediaAluno[i] = media;
        Console.WriteLine("Nota acima de 7: ");
        Console.WriteLine(vetorMediaAluno[i]);
    }
}
