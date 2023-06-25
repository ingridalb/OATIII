using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q39
    {
        public Q39()
        {
            int num;

            while (true) 
            {

                Console.WriteLine("QUESTÃO 39");
                Console.WriteLine();

                Console.Write("Insira um número: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("Número é par!");
                    if (num > 0)
                    {
                        Console.WriteLine("Número é positivo");
                    }
                    else
                    {
                        Console.WriteLine("Número é negativo");
                    }
                }
                else
                {
                    Console.WriteLine("Esse número é ímpar!");
                    if (num > 0)
                    {
                        Console.WriteLine("Número é positivo");
                    }
                    else
                    {
                        Console.WriteLine("Número é negativo");
                    }
                }
                Console.Write("");
                Console.Write("Deseja encerrar o programa? (Se sim digite a tecla 's'): ");
                string input = Console.ReadLine();


                if (input.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
