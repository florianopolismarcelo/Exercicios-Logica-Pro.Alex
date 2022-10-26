// See https://aka.ms/new-console-template for more information

/*****************************************************************
06 - Faça um programa que leia 5 números e informe o maior número.
*****************************************************************/

int i = 0, numero, maior = 0;

do
{
    Console.WriteLine("Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > maior)
        maior = numero;
    i = i + 1;

} while (i < 5);
Console.WriteLine("Maior: " + maior);
