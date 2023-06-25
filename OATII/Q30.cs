using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q30
    {
        public Q30()
        {

            int var1 = 1, var2 = 10, resultado;

            Console.WriteLine("QUESTÃO 30");
            Console.WriteLine();

            for (int i = var1; i <= var2; i++)
            {
                Console.WriteLine($"TABUADA DO {i}");
                Console.WriteLine();

                for (int j = var1; j <= var2; j++)
                {
                    resultado = i * j;
                    Console.WriteLine($"{i} x {j} = {resultado}");
                }
              
                    Console.WriteLine();
                    Console.ReadKey();
              
            }
        }
    }
}
