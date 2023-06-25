using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q6
    {
        public Q6()
        {
            decimal C, F;

            Console.WriteLine("QUESTÃO 06");
            Console.WriteLine("");

            Console.Write("Insira quantos graus está fazendo na sua cidade: ");
            C = decimal.Parse(Console.ReadLine());

            F = (9 * C + 160) / 5;

            Console.Clear();
            Console.WriteLine($"Na sua cidade está fazendo {C:F2} graus Celsius e {F:F2} graus FahrenHeit.");
            Console.ReadKey();
        }
    }
}
