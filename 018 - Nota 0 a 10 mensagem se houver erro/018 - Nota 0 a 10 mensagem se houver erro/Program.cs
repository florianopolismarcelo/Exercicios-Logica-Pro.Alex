// See https://aka.ms/new-console-template for more information

/*************************************************************************************************
001 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja 
inválido e continue pedindo até que o usuário informe um valor válido.
*************************************************************************************************/

float nota;
Boolean notaValida = false;

do
{
    Console.WriteLine("Digite uma nota entre 0 e 10:");
    nota = float.Parse(Console.ReadLine());
    if (nota >= 0 && nota <= 10)
    {
        notaValida = true;
        Console.WriteLine($"A nota digitada é {nota}");
    }
    else
    {
        notaValida = false;

        Console.WriteLine($"Você digitou {nota} favor digitar nota válida");
    }
} while (!notaValida);