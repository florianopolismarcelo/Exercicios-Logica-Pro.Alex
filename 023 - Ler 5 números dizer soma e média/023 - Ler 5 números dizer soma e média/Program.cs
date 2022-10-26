// See https://aka.ms/new-console-template for more information

int i = 0, soma = 0, numero, maior = 0;

do
{
    Console.Write("Número: ");
    numero = int.Parse(Console.ReadLine());

    soma = soma + numero;
    i = i + 1;

} while (i < 5);

Console.WriteLine("");
Console.WriteLine($"A soma de todos os números é: {soma} ");
Console.WriteLine("A média é: " + (soma / 5));