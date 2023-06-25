using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q31
    {
        public Q31()
        {
            int somaPares = 0, somaImpares = 0;
            int[] numeros = new int[5];

            Console.WriteLine("QUESTÃO 31");
            Console.WriteLine();

            for (int x = 0; x < 5; x++)
            {
                Console.Write("Insira CINCO números: ");
                numeros[x] = int.Parse(Console.ReadLine());

                if (numeros[x] < 0)
                {
                    Console.WriteLine("Número negativo inserido, fim dos dados.");
                }

                if (numeros[x] % 2 != 0)
                {
                    Console.WriteLine("ÍMPAR");
                    somaImpares += numeros[x];

                }
                else if (numeros[x] % 2 == 0)
                {
                    Console.WriteLine("PAR");
                    somaPares += numeros[x];
                }

            }
            Console.Clear();
            Console.WriteLine($"A soma dos números PARES é: {somaPares}.");
            Console.WriteLine($"A soma dos números ÍMPARES é: {somaImpares}");
            Console.ReadKey();
        }   
    }
}
