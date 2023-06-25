using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q13
    {
        public Q13()
        {
            int[] numeros = new int[3];

            Console.WriteLine("QUESTÃO 13");
            Console.WriteLine();

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("Insira três números:");
                numeros[x] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os números em ordem decrescente é:");
            Console.WriteLine("");
            Array.Sort(numeros);
            Array.Reverse(numeros);
            foreach (int numero in numeros)

            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
