using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q58
    {
        public Q58()
        {
            int quantidade; 

            Console.WriteLine("QUESTÃO 58");
            Console.WriteLine("----------");

            Console.Write("Escolha a quantidade de números que serão lidos: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maiorNum = numeros[0];
            int soma = numeros[0];
            for (int i = 1; i < quantidade; i++)
            {
                if (numeros[i] > maiorNum)
                    maiorNum = numeros[i];

                soma += numeros[i];
            }

            double mediaNum = (double)soma / quantidade;

            Console.Clear();
            Console.WriteLine($"A média dos números é: {mediaNum}");
            Console.WriteLine($"O maior número é: {maiorNum}");
            Console.ReadKey();

        }
    }
}
