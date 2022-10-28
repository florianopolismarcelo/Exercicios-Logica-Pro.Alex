// See https://aka.ms/new-console-template for more information

/*Faça um Programa que leia 20 números inteiros e armazene-os num vetor. 
 Armazene os números pares no vetor PAR e os números IMPARES no vetor impar. 
Imprima os três vetores.*/

int i = 0, par = 0, impar = 0, numero = 0;
int[] vetorPar = new int[20];
int[] vetorImpar = new int[20];
int[] vetorNumerosInt = new int[20];

for (i = 0; i < 20; i++)
{
    Console.Write("Digite um numero inteiro: ");
    numero = int.Parse(Console.ReadLine());
    vetorNumerosInt[i] = numero;
}
Console.WriteLine("----------------------------");
Console.WriteLine("Todos os números digitados: ");
Console.WriteLine("----------------------------");

for (i = 0; i < 20; i++)
{
    Console.WriteLine(vetorNumerosInt[i]);
}
Console.WriteLine("----------------------------");
Console.WriteLine("Numeros Pares:              ");
Console.WriteLine("----------------------------");

for (i = 0; i < 20; i++)
{
    if ((vetorNumerosInt[i] % 2) == 0)
    {
        vetorPar[i] = vetorNumerosInt[i];
        Console.WriteLine(vetorPar[i]);
        par = par + 1;
    }
}
Console.WriteLine("----------------------------");
Console.WriteLine("Numeros Impares:            ");
Console.WriteLine("----------------------------");

for (i = 0; i < 20; i++)
{
    if ((vetorNumerosInt[i] % 2) != 0)
    {
        vetorImpar[i] = vetorNumerosInt[i];
        Console.WriteLine(vetorImpar[i]);
        impar = impar + 1;
    }
}
