using System;
using System.Text.RegularExpressions;

namespace _007___Tabuada_com_tratamento_de_exceção
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Resultado, i = 1;
            Boolean verdade = true, frase;
            string Numero;

            //char  'e';

            //int[] Numero  = new int[10]{1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("+--------------------------------------------------------+");
            Console.WriteLine("DIGITE UM NUMERO INTEIRO DE 1 A 4 PARA FORMAR SUA TABUADA");
            Console.WriteLine("+--------------------------------------------------------+");
            Numero = (Console.ReadLine());

            frase = false;
            while (verdade)
            {
                bool ehValido = Regex.IsMatch(Numero, "^[0-9]+$");//expressão regular
                if (ehValido)
                {
                    // Console.WriteLine("Passou aqui");
                    for (i = 0; i < 11; i++)
                    {
                        // Console.WriteLine("Passou aqui");
                        Resultado = (Int32.Parse(Numero) * i);
                        Console.WriteLine(Numero + " X " + i + " = " + Resultado);
                    }
                    verdade = false;
                    frase = true;
                }
                else
                {
                    Console.WriteLine(Numero);
                    Console.WriteLine(ehValido);
                    Console.WriteLine(" Digite um número válido");
                }
                if (!frase)
                {
                    Console.WriteLine("+--------------------------------------------------------+");
                    Console.WriteLine("DIGITE UM NUMERO INTEIRO DE 1 A 4 PARA FORMAR SUA TABUADA");
                    Console.WriteLine("+--------------------------------------------------------+");
                    Numero = (Console.ReadLine());
                }
            }

            // if (Int32.Parse(Numero) != 1 && Int32.Parse(Numero) != 2 && Int32.Parse(Numero) != 3 && Int32.Parse(Numero) != 4 && Int32.Parse(Numero) != 5 
            //   && Int32.Parse(Numero) != 6 && Int32.Parse(Numero) != 7 && Int32.Parse(Numero) != 8 && Int32.Parse(Numero) != 9 && Int32.Parse(Numero) != 10 )
            //  {
            //  Console.WriteLine("+----------------------------------------------------------+");
            //   Console.WriteLine("NUMERO INVALIDO FAVOR ESCOLHA UM NUMERO INTEIRO ENTRE 1 A 10");
            //  Console.WriteLine("+----------------------------------------------------------+");

            // }
        }
    }
}
