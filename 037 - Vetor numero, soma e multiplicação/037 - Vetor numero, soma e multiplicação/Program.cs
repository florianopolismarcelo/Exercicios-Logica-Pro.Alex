// See https://aka.ms/new-console-template for more information

/*Faça um Programa que leia um vetor de 5 números inteiros, mostre a soma, a multiplicação e os números.*/

int[] vetorNumeros = new int[5];
int[] vetorSoma = new int[5];
int[] vetorMultiplicacao = new int[5];


int numero = 0, soma = 0, multiplicacao = 0, i = 0;



for (i = 0; i < 5; i++)
{
    //Console.WriteLine("Digite o número na posição {0}: ", i);
    Console.Clear();
    Console.Write("Digite um numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    vetorNumeros[i] = numero;

    soma = vetorNumeros[0] + vetorNumeros[1] + vetorNumeros[2] + vetorNumeros[3] + vetorNumeros[4];

    multiplicacao = vetorNumeros[1] * vetorNumeros[2] * vetorNumeros[3] * vetorNumeros[4];
}
Console.WriteLine("Os números digitados são: ");
for (i = 0; i < 5; i++)
{
    Console.WriteLine(vetorNumeros[i]);
}
Console.Write("A soma de todos os números é: ");
Console.WriteLine(soma);
Console.Write("A multiplicação de todos os números é: ");
Console.WriteLine(multiplicacao);



