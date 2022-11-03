// See https://aka.ms/new-console-template for more information

/*Faça um Programa que peça as quatro notas de 10 alunos, calcule e armazene num vetor a média 
de cada aluno, imprima o número de alunos com média maior ou igual a 7.0.*/


double[] vetorNotaAluno = new double[4];
double[] vetorMediaAluno = new double[2];

double nota = 0, media = 0, soma = 0;

int n = 0, i = 0;


for (i = 0; i < 2; i++)
{
    Console.WriteLine("---------------------------");
    Console.WriteLine("Nota do aluno na posição {0}: ", i);
    Console.WriteLine("---------------------------");

    for (n = 0; n < 2; n++)
    {
        Console.Write("Digite a nota: ");
        nota = Convert.ToInt32(Console.ReadLine());
        //vetorNotaAluno[n] = nota;

        media = media + nota;
        //media = vetorNotaAluno[0] + vetorNotaAluno[1] + vetorNotaAluno[2] + vetorNotaAluno[3];
    }
    media = media / 2;
    vetorMediaAluno[i] = media;
    media = 0;
}
Console.WriteLine("----------------");
Console.WriteLine("Todas as médias: ");
Console.WriteLine("----------------");

for (i = 0; i < 2; i++)
{
    Console.WriteLine(vetorMediaAluno[i]);

    if (vetorMediaAluno[i] >= 7)
    {
        //Console.WriteLine(vetorMediaAluno[i]);
        soma = soma + 1;
       
    }
    Console.WriteLine(soma);
}









//}
//Console.WriteLine("---------------------------");
//Console.WriteLine("Médias igual ou acima de 7: ");
//Console.WriteLine("---------------------------");

//for (i = 0; i < 2; i++)
//{

