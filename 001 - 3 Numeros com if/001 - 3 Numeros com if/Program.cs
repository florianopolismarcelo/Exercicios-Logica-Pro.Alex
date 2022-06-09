using System;

namespace _001___3_Numeros_com_if
{   /*Escrever um algoritmo para ler e imprimir  3 números, se o primeiro for
     positivo, imprimir sua raiz quadrada , caso contrário, imprimir o seu
     quadrado; se o segundo número for maior que 10 e menor que 100, imprimir
     a mensagem: "Número está entre 10 e 100 - intervalo permitido"; se o terceiro
     número for menor que o segundo, calcular e imprimir a diferença entre eles
     caso ao contrário, imprimir o terceiro número adicionado de 1. */
    class Program
    {
        static void Main(string[] args)
        {
            double Numero1, Numero2, Numero3, NumeroDiferenca;
            Console.WriteLine("+-----------------------+");
            Console.WriteLine("INFORME O PRIMEIRO NUMERO");
            Console.WriteLine("+-----------------------+");
            Numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("+----------------------+");
            Console.WriteLine("INFORME O SEGUNDO NUMERO");
            Console.WriteLine("+----------------------+");
            Numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("+-----------------------+");
            Console.WriteLine("INFORME O TERCEIRO NUMERO");
            Console.WriteLine("+-----------------------+");
            Numero3 = double.Parse(Console.ReadLine());

            if (Numero1 > 0 && Numero1 <= 10)
            {
                Numero1 = Math.Sqrt(Numero1);
                //Numero1 = Numero1 * Numero1;
                Console.WriteLine("+------------------------------------------+");
                Console.WriteLine("RAIZ QUADRADA NO PRIMEIRO NUMERO = " + Numero1.ToString("0.00"));
                Console.WriteLine("+------------------------------------------+");
                /*+Numero1.ToString("0.00") para formatar pode usar o ("N2") ou ("F") 
                consultar documentação "CADEIAS DE CARACTERES DE FORMATO NUMÉRICO PADRÃO C#."*/
            }
            else
            {
                Numero1 = Math.Pow(Numero1, 2);
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("O PRIMEIRO NUMERO ELEVADO AO QUADRADO E = " + Numero1);
                Console.WriteLine("+--------------------------------------------+");
            }
            if (Numero2 > 10 && Numero2 < 100)
            {
                Console.WriteLine("+-------------------------------------------------------------+");
                Console.WriteLine("O SEGUNDO NUMERO = " + Numero2 + " ESTA ENTRE 10 E 100 - INTERVALO PERMITIDO");
                Console.WriteLine("+-------------------------------------------------------------+");
            }
            if (Numero3 < Numero2)
            {
                NumeroDiferenca = Numero2 - Numero3;
                Console.WriteLine("+-----------------------------------------------------------------------+");
                Console.WriteLine("TERCEIRO NUMERO = " + Numero3 + " E MENOR QUE O SEGUNDO NUMERO = " + Numero2 + " A DIFERENCA E = " + NumeroDiferenca);
                Console.WriteLine("+-----------------------------------------------------------------------+");
            }
            else
            {
                NumeroDiferenca = Numero3 + 1;
                Console.WriteLine("+-------------------------------------------------+");
                Console.WriteLine("TERCEIRO NUMERO E MAIOR QUE O SEGUNDO = " + Numero3 + " + 1 = " + NumeroDiferenca);
                Console.WriteLine("+-------------------------------------------------+");
            }
        }
    }
}
