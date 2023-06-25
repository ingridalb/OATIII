using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q17
    {
        public Q17() 
        {

            int num1;

            Console.WriteLine("QUESTÃO 17");
            Console.WriteLine("");
            Console.Write("Insira um número inteiro: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();
            
            if (num1 >=0 && num1 <=9)
            {
                Console.WriteLine("Valor válido!");
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
            Console.ReadKey();
        }
    }
}
