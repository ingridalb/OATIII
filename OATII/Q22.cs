using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q22
    {
        public Q22()
        {
            int num, A, B;

            Console.WriteLine("QUESTÃO 22");
            Console.WriteLine("");
            Console.Write("Insira um número: ");
            num = int.Parse(Console.ReadLine());
            Console.Clear();

            if (num >= 0)
            {
                A = num;
                Console.WriteLine($"O número que você digitou é: {A}.");
            }
            else
            {
                B = num;
                Console.WriteLine($"O número que você digitou é: {B}.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
