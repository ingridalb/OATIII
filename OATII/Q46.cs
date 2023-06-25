using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q46
    {
        public Q46()
        {

            Console.WriteLine("QUESTÃO 46");
            Console.WriteLine();

            Console.Write("Digite a quantidade de números que você deseja: ");
            int n = int.Parse(Console.ReadLine());

            int[] x = new int[n];
            int[] y = new int[n];
            Console.Clear();

            Console.WriteLine("Digite os números do vetor x:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear(); 

            Console.WriteLine("Digite os número do vetor y:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            int produtoEscalar = 0;

            for (int i = 0; i < n; i++)
            {
                produtoEscalar += x[i] * y[i];
            }

            Console.Clear();
            Console.WriteLine($"O produto escalar dos vetores x e y é: {produtoEscalar}");

            Console.ReadKey();
        }
    }
}
