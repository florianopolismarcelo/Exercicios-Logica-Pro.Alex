using System;

namespace _013___Conta_banco_com_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Saldo = 500, Saque, Deposito, Transferencia = 0;
            float Numero;
            Boolean verdade = true;

            while (verdade)
            {

                Console.WriteLine("SEU SALDO ATUAL É DE 500,00");
                Console.WriteLine("DIGITE 1 PARA SAQUE");
                Console.WriteLine("DIGITE 2 PARA DEPOSITO");
                Console.WriteLine("DIGITE 3 PARA TRANSFERENCIA");
                Console.WriteLine("DIGITE 4 PARA EXTRATO");
                Console.WriteLine("DIGITE 9 PARA SAIR");
                Numero = int.Parse(Console.ReadLine());

                switch (Numero)
                {

                    case 1:
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
                        break;

                    case 2:
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
                            break;
                        }
                    case 3:
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
                            break;
                        }
                        // case 9:
                        //  {
                        //  Environment.Exit(0);
                        // }
                        // break;
                }

                if (Numero == 9)
                    {
                    verdade = false;
                }
            }

        }
    }
}