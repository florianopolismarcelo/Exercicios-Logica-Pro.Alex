// See https://aka.ms/new-console-template for more information

/* 014 - Faça um Programa que leia um vetor de 5 números inteiros e mostre-os. */


int[] vetorInt = new int[5];

int numero = 0;

for (int i = 0; i < 5; i++)
{
    Console.Clear();
    Console.WriteLine("Digite o {0} numero: ", i);

    numero = Convert.ToInt32(Console.ReadLine());
    vetorInt[i] = numero;

}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Numeros digitados: ");
    Console.WriteLine(vetorInt[i]);

}

