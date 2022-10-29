// See https://aka.ms/new-console-template for more information

/*Faça um Programa que peça as quatro notas de 10 alunos, calcule e armazene num vetor a média 
de cada aluno, imprima o número de alunos com média maior ou igual a 7.0.*/

//string[] vetorNomeAluno = new string[10];
int[] vetorNomeAluno = new int[2];
double[] vetorNotaAluno = new double[4];
double[] vetorMediaAluno = new double[1];

double nota = 0, media = 0;
string nome;
int i = 0, a=0;

for (i = 0; i < vetorNomeAluno.Length; i++)
{


    for (i = 0; i < 4; i++)
    {
        Console.WriteLine("Digite a nota: ");
        nota = Convert.ToInt32(Console.ReadLine());
        vetorNotaAluno[i] = nota;

        media = vetorNotaAluno[0] + vetorNotaAluno[1] + vetorNotaAluno[2] + vetorNotaAluno[3];
        media = media / 4;
        vetorMediaAluno[i] = media;


        //if (media >= 7)
        //{
        //    vetorMediaAluno[i] = media;
        //    Console.WriteLine(vetorMediaAluno[i]);
        //}

    }
    Console.WriteLine($"A Media é: {media}");
}