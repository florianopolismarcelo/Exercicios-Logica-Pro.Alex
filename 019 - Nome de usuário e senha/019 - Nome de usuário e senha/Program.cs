// See https://aka.ms/new-console-template for more information

/*************************************************************************************
Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual 
ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações. 
 ************************************************************************************/


string nome, senha;

Console.Write("Digite seu nome de usuário: ");
nome = Console.ReadLine();

Console.Write("Digite sua senha: ");
senha = Console.ReadLine();

do
{
    Console.Clear();
    Console.WriteLine("Senha não pode ter o mesmo nome do usuário");
    Console.Write("Favor digite sua senha: ");
    senha = Console.ReadLine();
} while (nome == senha);

Console.WriteLine($"Ok, usuário {nome} senha ***** validada com sucesso!");

//if (nome != senha)
//{
//Console.Clear();

//Corrigido com Alex