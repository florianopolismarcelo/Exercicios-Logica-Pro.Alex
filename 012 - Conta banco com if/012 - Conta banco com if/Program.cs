using System;

namespace _012___Conta_banco_com_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero, Saldo = 500, Saque, Deposito, Transferencia = 0;

            Console.WriteLine("SEU SALDO ATUAL É DE 500,00");
            Console.WriteLine("DIGITE 1 PARA SAQUE");
            Console.WriteLine("DIGITE 2 PARA DEPOSITO");
            Console.WriteLine("DIGITE 3 PARA TRANSFERENCIA");
            Console.WriteLine("DIGITE 4 PARA EXTRATO");
            Console.WriteLine("DIGITE 9 PARA SAIR");
            Numero = int.Parse(Console.ReadLine());

            if (Numero == 1)
            {
                Console.WriteLine("DIGITE O VALOR PARA SAQUE");
                Saque = int.Parse(Console.ReadLine());

                if (Saque > 500)
                {
                    Console.WriteLine("SALDO INDISPONIVEL");
                }
                else
                {
                    Saldo = Saldo - Saque;
                    Console.WriteLine("SEU SALDO ATUAL E DE :" + Saldo);
                }
            }
            if (Numero == 2)
            {
                Console.WriteLine("DIGITE O VALOR QUE DESEJA DEPOSITAR");
                Deposito = int.Parse(Console.ReadLine());

                if (Deposito > 0)
                {
                    Saldo = Saldo + Deposito;
                    Console.WriteLine("SEU SALDO ATUAL E DE :" + Saldo);
                }
                else
                {
                    Console.WriteLine("ESSE VALOR NAO E VALIDO");
                }
            }
            if (Numero == 3)
            {
                Console.WriteLine("DIGITE O VALOR QUE DESEJA TRANSFERIR");
                Transferencia = int.Parse(Console.ReadLine());

                if (Transferencia > Saldo)
                {
                    Console.WriteLine("SALDO INDISPONIVEL");
                }
                else
                {
                    Transferencia = Saldo - Transferencia;
                    Saldo = Transferencia;
                    Console.WriteLine("SEU SALDO ATUAL E DE :" + Saldo);
                }
            }
            if (Numero == 9)
            {
                Console.WriteLine("TECLE QUALQUER TECLA PARA SAIR");
            }
        }
    }
}
