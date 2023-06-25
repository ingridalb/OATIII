using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q14
    {
        public Q14()
        {
            int num1, num2, diferenca;

            Console.WriteLine("QUESTÃO 14");
            Console.WriteLine("");

            Console.Write("Insira o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();

            diferenca = Math.Abs(num1 - num2);

            Console.WriteLine($"1° número = {num1}, 2° número = {num2}, diferença de valor entre eles = {diferenca}.");
            Console.ReadKey();

        }
    }
}
