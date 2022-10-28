// See https://aka.ms/new-console-template for more information

/*Faça um Programa que leia 4 notas, mostre as notas e a média na tela.*/

double[] vetorInt = new double[4];

double nota = 0, media = 0;


for (int i = 0; i < 4; i++)
{
    Console.Clear();
    Console.WriteLine("Digite a nota: ");

    nota = Convert.ToInt32(Console.ReadLine());
    vetorInt[i] = nota;
}

Console.WriteLine("As notas são: ");

for (int i = 0; i < 4; i++)

{
    Console.WriteLine(vetorInt[i]);
    media = vetorInt[0] + vetorInt[1] + vetorInt[2] + vetorInt[3];
    media = media / 4;
}
Console.WriteLine($"A Media é: {media}");
