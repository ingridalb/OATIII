using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q8
    {
        public Q8()
        {
            decimal V, R, A;

            Console.WriteLine("QUESTÃO 08");
            Console.WriteLine("");
            Console.Write("Insira o raio da lata: ");
                R = decimal.Parse(Console.ReadLine());
            Console.Write("Insira a altura da lata: ");
                A = decimal.Parse(Console.ReadLine());

                V = 3.14159m * R * R * A;

            Console.Clear();
            Console.WriteLine($"O volume da lata de óleo é: {V:F2}");
            Console.ReadKey();

        }
    }
}
