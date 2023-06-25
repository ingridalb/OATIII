using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q36
    {
        public Q36() 
        {
            int[] numeros = new int[10];
            int media, soma = 0, maior  = 0, menor;
            

            Console.WriteLine("QUESTÃO 36");
            Console.WriteLine();

            Console.Write("INSIRA UM NÚMERO: ");
            numeros[0] = int.Parse(Console.ReadLine());
            menor = numeros[0];
            maior = numeros[0];
            soma += numeros[0];

            for (int i = 1; i <10; i++)
            {
                Console.Write("INSIRA UM NÚMERO: ");
                numeros[i] = int.Parse(Console.ReadLine());
                maior = Math.Max(numeros[i], maior);
                menor = Math.Min(numeros[i], menor);
                soma += numeros[i];
            }

                media = soma / 10;
                Console.Clear();
                Console.WriteLine($"MÉDIA DOS NÚMEROS: {media}");
                Console.WriteLine($"O maior valor digitado é: {maior}.");
                Console.WriteLine($"O menor valor digitado é: {menor}.");
                Console.ReadKey();
        }
    }
}
