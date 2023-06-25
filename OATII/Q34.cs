using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q34
    {
        public Q34()
        {

            int maior = 0, menor = 0;
            int[] numeros = new int[3];

            Console.WriteLine("QUESTÃO 34");
            Console.WriteLine();

            for (int x = 0; x < 3; x++)
            {
                Console.Write("Insira três números: ");
                numeros[x] = int.Parse(Console.ReadLine());

                if (numeros[x] < 0)
                {
                    Console.WriteLine("Número negativo inserido, fim dos dados.");
                }

                maior = Math.Max(numeros[x], maior);
                menor = Math.Min(numeros[x], menor);
            }

            Console.Clear();
            Console.WriteLine($"O maior valor digitado é: {maior}.");
            Console.WriteLine($"O menor valor digitado é: {menor}.");
            Console.ReadKey();
        }
    }
}
