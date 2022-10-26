// See https://aka.ms/new-console-template for more information

int numero1, numero2;

Console.WriteLine("Informe o primeiro número inteiro:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número inteiro:");
numero2 = int.Parse(Console.ReadLine());

for (int i = numero1; i <= numero2; i++)
{
    Console.WriteLine(i);
}
//Console.ReadKey();
