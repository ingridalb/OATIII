using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q40
    {
        public Q40()
        {

            decimal poluicao;

            while (true)
            {
                Console.WriteLine("QUESTÃO 40");
                Console.WriteLine();

                Console.Write("Insira o nível de poluição: ");
                poluicao = decimal.Parse(Console.ReadLine());

                if (poluicao == 0.3m)
                {
                    Console.WriteLine("1° grupo paralise suas atividades!");
                }
                else if (poluicao == 0.4m)
                {
                    Console.WriteLine("1° e 2° grupo paralisem suas atividades!");
                }
                else if (poluicao >= 0.5m)
                {
                    Console.WriteLine("Todos os grupos devem paralisarem as atividades!");
                }
                else 
                {
                    Console.WriteLine("Nível de poluição aceitável!");
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
