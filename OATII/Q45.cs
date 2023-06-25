using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q45
    {
        public Q45()
        {

            Console.WriteLine("QUESTÃO 45");
            Console.WriteLine();

            Console.Write("Digite a quantidade de números que você deseja: ");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Clear();
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Números digitados na forma inversa:");

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadKey();
        }
    }
}
