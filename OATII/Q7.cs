using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q7
    {
        public Q7()
        {
            decimal C, F;

            Console.WriteLine("QUESTÃO 07");
            Console.WriteLine("");

            Console.Write("Insira quantos graus está fazendo na sua cidade: ");
            F = decimal.Parse(Console.ReadLine());

            C = (F - 32) * 5 / 9;

            Console.Clear();
            Console.WriteLine($"Na sua cidade está fazendo {C:F2} graus Fahrenheit e {F:F2} graus Celsius.");
            Console.ReadKey();
        }
    }
}
