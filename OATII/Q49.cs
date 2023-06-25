using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q49
    {
        public Q49()
        {

            int N;

            Console.WriteLine("QUESTÃO 49");
            Console.WriteLine(); 

            Console.Write("Informe a quantidade de vetores (no máximo 50): ");
            Console.WriteLine(" ");
            N = int.Parse(Console.ReadLine());

            int[] V1 = new int[N];
            int[] V2 = new int[N];

            Console.WriteLine("Informe os valores do vetor V1:");
            for (int i = 0; i < V1.Length; i++)
            {
                Console.Write($"Informe o valor {i + 1}: ");
                V1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");
            Console.WriteLine("Informe os valores do vetor V2:");
            for (int i = 0; i < V2.Length; i++)
            {
                Console.Write($"Informe o valor {i + 1}: ");
                V2[i] = int.Parse(Console.ReadLine());
            }

            int contador = 0;

            for (int i = 0; i < V1.Length; i++)
            {
                if (V1[i] == V2[i])
                {
                    contador++;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine($"Quantidade de números iguais nas mesmas posições: {contador}");

            Console.ReadKey();
        }
    }
}
