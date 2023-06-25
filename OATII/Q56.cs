using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q56
    {
        public Q56() 
        {

            Console.WriteLine("QUESTÃO 56");
            Console.WriteLine("----------");

            int[] numeros = new int[50];
            for (int i = 0; i < 50; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int qtdePares = 0;
            int qtdeMultiplos = 0;

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                    qtdePares++;

                if (numero % 5 == 0)
                    qtdeMultiplos++;
            }

            Console.Clear();
            Console.WriteLine($"Quantidade de números pares: {qtdePares}");
            Console.WriteLine($"Quantidade de múltiplos de 5: {qtdeMultiplos}");
            Console.ReadKey();
        }
    }
}
