// See https://aka.ms/new-console-template for more information

/*016 - Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem inversa. */

int[] vetorInt = new int[10];

int numero = 0;

for (int i = 0; i < 5; i++)
{
    //Console.Clear();
    Console.WriteLine("Digite o {0} numero: ", i);

    numero = Convert.ToInt32(Console.ReadLine());
    vetorInt[i] = numero;
}
Console.WriteLine("Numeros digitados: ");

for (int i = 9; i >= 0; i--)

{
    Console.WriteLine(vetorInt[i]);
}