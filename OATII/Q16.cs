using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q16
    {
        public Q16()
        {

            int num1, num2;

            Console.WriteLine("QUESTÃO 16");
            Console.WriteLine("");
            Console.Write("Insira o valor do primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor do segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} é maior que {num2}.");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"{num2} é maior que {num1}.");
            }
            else
            {
                Console.WriteLine("Os números são iguais!");
            }
            Console.ReadKey();
        }
    }
}
