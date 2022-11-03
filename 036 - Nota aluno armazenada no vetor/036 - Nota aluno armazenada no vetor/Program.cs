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




//*Faça um Programa que leia um vetor de 5 números inteiros, mostre a soma, a multiplicação e os números.*/

//int[] vetorNumeros = new int[5];
//int[] vetorSoma = new int[5];
//int[] vetorMultiplicacao = new int[5];

//int numero = 0, soma = 0, multiplicacao = 0, i = 0;

//for (i = 0; i < 5; i++)
//{
//    //Console.WriteLine("Digite o número na posição {0}: ", i);
//    Console.Clear();
//    Console.Write("Digite um numero: ");
//    numero = Convert.ToInt32(Console.ReadLine());
//    vetorNumeros[i] = numero;

//    soma = vetorNumeros[0] + vetorNumeros[1] + vetorNumeros[2] + vetorNumeros[3] + vetorNumeros[4];

//    multiplicacao = vetorNumeros[1] * vetorNumeros[2] * vetorNumeros[3] * vetorNumeros[4];
//}
//Console.WriteLine("Os números digitados são: ");
//for (i = 0; i < 5; i++)
//{
//    Console.WriteLine(vetorNumeros[i]);
//}
//Console.Write("A soma de todos os números é: ");
//Console.WriteLine(soma);
//Console.Write("A multiplicação de todos os números é: ");
//Console.WriteLine(multiplicacao);




//}
//Console.WriteLine("---------------------------");
//Console.WriteLine("Médias igual ou acima de 7: ");
//Console.WriteLine("---------------------------");

//for (i = 0; i < 2; i++)
//{

