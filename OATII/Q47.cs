using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q47
    {
        public Q47()
        {

            int[] vetor = new int[10];
            int x, maiores = 0, menores = 0, iguais = 0;

            Console.WriteLine("QUESTÃO 47");
            Console.WriteLine();

            Console.WriteLine("Digite os 10 números do vetor:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("");
                Console.Write($"Digite o número {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");
            Console.Write("Digite o número X: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] > x)
                {
                    maiores++;
                }
                else if (vetor[i] < x)
                {
                    menores++;
                }
                else
                {
                    iguais++;
                }
            }

            Console.Clear();
            Console.WriteLine($"Quantidade de números maiores que X: {maiores}");
            Console.WriteLine($"Quantidade de números menores que X: {menores}");
            Console.WriteLine($"Quantidade de números iguais a X: {iguais}");

            Console.ReadKey();
        }
    }
}
