using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q26
    {
        public Q26()
        {

            int inicio = 100, fim = 1;

            Console.WriteLine("QUESTÃO 26");
            Console.WriteLine();
            Console.WriteLine("1 à 100 em ordem decrescente:");

            for (int i = inicio; i >= fim; i--)
            {

                Console.Write(i+ " ");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
