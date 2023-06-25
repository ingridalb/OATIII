using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q55
    {
        public Q55()
        {
            int[] vetor = new int[50];

            Console.WriteLine("QUESTÃO 55");
            Console.WriteLine("----------");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Informe o número da posição {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int pares = 0;
            int multiplos = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                    pares++;

                if (vetor[i] % 5 == 0)
                    multiplos++;
            }

            Console.Clear();
            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de múltiplos de 5: {multiplos}");
            Console.ReadKey();
        }
    }
}
