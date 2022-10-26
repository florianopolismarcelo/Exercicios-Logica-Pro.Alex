// See https://aka.ms/new-console-template for more information

/********************************************************************************
09 - Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50.
********************************************************************************/

int x;

for (int i = 1; i <= 50; i++)
{
    x = i;
    if (x % 2 != 0)
        Console.WriteLine(x);
}