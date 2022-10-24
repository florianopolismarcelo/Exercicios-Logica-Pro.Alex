// See https://aka.ms/new-console-template for more information

/*************************************************************************************************
003 - Faça um programa que leia e valide as seguintes informações:
Nome: maior que 3 caracteres;
Idade: entre 0 e 150;
Salário: maior que zero;
Sexo: 'f' ou 'm';
Estado Civil: 's', 'c', 'v', 'd';
*************************************************************************************************/
using System;


string nome;
char sexo = 'y', estadoCivil = 'z';
int idade = 0;
do
{
    Console.Write("Digite sua idade [precisa ter no minimo 4 caracter]: ");
    nome = Console.ReadLine();

} while (nome.Length <= 3);
do
{
    Console.Write("Digite sua idade [Apenas entre 0 a 150 anos]: ");
    idade = int.Parse(Console.ReadLine());

} while (idade < 0 || idade > 150);
do
{
    Console.Write("Você precisa digitar 'm' para Marculino ou 'f' para Feminino: ");
    sexo = char.Parse(Console.ReadLine());

} while (sexo != 'm' && sexo != 'f');
do
{
    Console.Write("Você precisa digitar 's' para Solteiro 'c' para Casado 'v' para viúvo e 'd' se for divorciado: ");
    estadoCivil = char.Parse(Console.ReadLine());

} while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd');

Console.WriteLine("-------------------------------------------------------------------");
Console.Write($" Seu nome: {nome} " +
              $" tem: {idade} anos" +
              $" é do sexo: {sexo} " +
              $" seu estado civil: {estadoCivil} ");
Console.WriteLine("\n-------------------------------------------------------------------");
