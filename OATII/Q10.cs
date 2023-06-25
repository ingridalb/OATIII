using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q10
    {
        public Q10()
        {
            int A, B;


            Console.WriteLine("QUESTÃO 10");
            Console.WriteLine("");
            Console.Write("Insira o valor de 'A': ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor de 'B': ");
            B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                Console.WriteLine("Os números são iguais!");
            }
            else if (A > B)
            {
                Console.WriteLine("Os números são diferentes, A é maior que B!");
            }
            else
            {
                Console.WriteLine("Os números são diferentes, A é menor que B");
            }

            Console.ReadKey();
        }
    }
}
