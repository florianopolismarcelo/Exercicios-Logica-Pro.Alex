// See https://aka.ms/new-console-template for more information

/* 04 - Faça um Programa que leia um vetor de 10 caracteres, e diga quantas consoantes 
 foram lidas. Imprima as consoantes.*/

char consoantes = 'x';
int soma = 0;
char[] vetorChar = new char[10];

for (int i = 0; i < 10; i++)
{
    Console.Write("Digite um caracter: ");
    consoantes = char.Parse(Console.ReadLine());
    vetorChar[i] = consoantes;
}
Console.WriteLine("------------------");
Console.WriteLine("As consoantes são: ");
Console.WriteLine("------------------");


for (int i = 0; i < 10; i++)
{
    if (vetorChar[i] != 'a' && vetorChar[i] != 'e' && vetorChar[i] != 'i' && vetorChar[i] != 'o' && vetorChar[i] != 'u')

    {
        Console.WriteLine($"{vetorChar[i]}");

        soma = soma + 1;
    }
}
Console.WriteLine("------------------");
Console.Write("A quantidade é: ");

Console.WriteLine(soma);
Console.WriteLine("------------------");
