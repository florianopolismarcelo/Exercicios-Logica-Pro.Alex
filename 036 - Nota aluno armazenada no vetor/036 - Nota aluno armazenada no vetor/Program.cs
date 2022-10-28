// See https://aka.ms/new-console-template for more information

/*Faça um Programa que peça as quatro notas de 10 alunos, calcule e armazene num vetor a média 
de cada aluno, imprima o número de alunos com média maior ou igual a 7.0.*/

string[] vetorNomeAluno = new string[3];
double[] vetorNotaAluno = new double[4];
double[] vetorMediaAluno = new double[1];

double nota = 0, media = 0;
string nome;
int i = 0;

for (i = 0; i < 1; i++)
{
    Console.WriteLine("Digite o nome do aluno: ");
    nome = (Console.ReadLine());
    vetorNomeAluno[i] = nome;
}
for (i = 0; i < 4; i++)
{
    Console.WriteLine("Digite a nota: ");
    nota = Convert.ToInt32(Console.ReadLine());
    vetorNotaAluno[i] = nota;
}
for (i = 0; i < 4; i++)

{
    Console.WriteLine(vetorNotaAluno[i]);
    media = vetorNotaAluno[0] + vetorNotaAluno[1] + vetorNotaAluno[2] + vetorNotaAluno[3];
    media = media / 4;
}
Console.WriteLine($"a media é: {media}");
