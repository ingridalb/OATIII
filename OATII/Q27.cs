using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q27
    {
        public Q27()
        {
            int numero, qtde;
            long fatorial;
            
            Console.WriteLine("QUESTÃO 27");
            Console.WriteLine();

            Console.Write("Informe a quantidade de números que você deseja que sejam processados: ");
            qtde = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= qtde; i++)
            {
                Console.Write($"Digite o número {i}: ");
                numero = int.Parse(Console.ReadLine());

                fatorial = 1;
                for (int j = 1; j <= numero; j++)
                {
                    fatorial *= j;
                }

                Console.Clear();
                Console.WriteLine($"O fatorial do número {numero} é: {fatorial}.");
            }

            Console.ReadKey();
        }
    }
}
