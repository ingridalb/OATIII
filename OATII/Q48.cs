using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q48
    {
        public Q48()
        {

            string[] nomes = new string[20];
            int[] idades = new int[20];
            int contador = 0;

            Console.WriteLine("QUESTÃO 48");
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Informe o nome da candidata {i + 1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"Informe a idade da candidata {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());

                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    contador++;
                }
            }

            string[] candidatasAptas = new string[contador];
            int index = 0;

            for (int i = 0; i < 20; i++)
            {
                if (idades[i] >= 18 && idades[i] <= 20)
                {
                    candidatasAptas[index] = nomes[i];
                    index++;
                }
            }

            Console.Clear();
            Console.WriteLine("Candidatas aptas a concorrer à campanha milionária: ");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(candidatasAptas[i]);
            }

            Console.ReadKey();

        }
    }
}
