using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q20
    {
        public Q20() 
        {

            int A, B, C, menor, maior, mult;
            double div;



            Console.WriteLine("QUESTÃO 20");
            Console.WriteLine("");

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            while (A < 0)
            {

                Console.Write("O valor digitado não é válido, insira um valor maior que 0: ");
                A = int.Parse(Console.ReadLine());

            }
 
            Console.Write("Digite o valor de B: ");

            B = int.Parse(Console.ReadLine());

            while (B < 0)
            {

                Console.Write("O valor digitado não é válido, insira um valor maior que 0: ");
                B = int.Parse(Console.ReadLine());

            }

            Console.Write("Insira o valor de C: ");
            C = int.Parse(Console.ReadLine());

            while (C < 0)
            {

                Console.Write("O valor digitado não é válido. Digite um valor válido (Maior que 0): ");
                C = int.Parse(Console.ReadLine());

            }

            menor = Math.Min(A, Math.Min(B, C));
            maior = Math.Max(A, Math.Max(B, C));
            Console.WriteLine($"O menor valor é: {menor}.");
            Console.WriteLine($"O maior valor é: {maior};");

            mult = menor * maior;
            div = maior / menor;

            Console.WriteLine($"Menor valor multiplicado pelo maior: {mult}");
            Console.WriteLine($"Maior valor dividido pelo menor: {div:F2}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
