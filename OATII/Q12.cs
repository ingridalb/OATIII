using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q12
    {
        public Q12()
        {
            int X, valorX;

            Console.WriteLine("QUESTÃO 12");
            Console.WriteLine("");

            Console.Write("Insira um número positivo ou negativo para 'X': ");
            X = int.Parse(Console.ReadLine());
            Console.Clear();

            if (X >= 0)
            {
                Console.WriteLine($"{X} é um valor positivo, ele é maior ou igual a '0'.");
            }
            else if (X <0)
            {
                valorX = X * (-1);
                Console.WriteLine($"X é um valor negativo, o módulo de X é: {valorX}.");
            }
            else
            {
                Console.WriteLine("Valor indisponível!");
            }
            Console.ReadKey();
        }
    }
}
