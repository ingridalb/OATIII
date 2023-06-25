using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q29
    {
        public Q29()
        {

            int inicio = 1, fim = 2000;

            Console.WriteLine("QUESTÃO 29");
            Console.WriteLine();
            Console.WriteLine("1 à 2000");

            for (int i = inicio; i <= fim; i++)
            {

                Console.Write(i+ " ");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
