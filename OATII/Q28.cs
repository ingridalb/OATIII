using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q28
    {
        public Q28()
        {

            int var1 = 100, var2 = 200;

            Console.WriteLine("QUESTÃO 28");
            Console.WriteLine();
            Console.WriteLine("NÚMEROS ÍMARES ENTRE 100 E 200");

            for (int i = var1; i <= var2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i+ " ");
                }

            } Console.ReadKey();
            Console.Clear();

        }
    }
}
