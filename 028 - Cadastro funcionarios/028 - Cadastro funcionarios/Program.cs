// See https://aka.ms/new-console-template for more information

int opcao;
float addSalario = 0;
string addNome = "";
string addCargo = "";
Boolean verdade = true;


List<string> nome = new List<string>();
List<string> cargo = new List<string>();
List<float> salario = new List<float>();

do
{
    Console.WriteLine("SELECIONE UMA OPÇÃO ABAIXO:");
    Console.WriteLine("");
    Console.WriteLine("1 - CADASTRAR");
    Console.WriteLine("2 - MOSTRAR");
    Console.WriteLine("3 - SAIR");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:

            Console.WriteLine("ADICIONAR NOME");
            addNome = Console.ReadLine();
            nome.Add(addNome);

            Console.WriteLine("ADICIONAR CARGO");
            addCargo = Console.ReadLine();
            cargo.Add(addCargo);

            Console.WriteLine("ADICIONAR SALARIO");
            addSalario = float.Parse(Console.ReadLine());
            salario.Add(addSalario);
            break;


        case 2:
            Console.WriteLine($"Nome: {addNome} Funcionario: {addCargo} Salário: {addSalario}");
            break;


        case 3:
            if (opcao == 2)
            {
                verdade = false;
            }
            break;
    }

} while (opcao != 3);
