using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q38
    {
        public Q38()
        {

            int C, N, E, multN, multE;

            while (true)
            { 
                Console.WriteLine("QUESTÃO 38");
                Console.WriteLine();

                Console.Write("INSIRA SEU CÓDIGO DE TRABALHO: ");
                C = int.Parse(Console.ReadLine());
                Console.Write("INFORME O NÚMERO DE HORAS TRABALHADAS: ");
                N = int.Parse(Console.ReadLine());
                Console.Clear();

                if (N > 50)
                {
                    E = N - 50; N = 50 - E;
                    multN = (N * 10); multE = (E * 20);

                    Console.WriteLine($"O funcionário código |{C}| receberá |R${multN:F2}| e mais |R${multE:F2}| de horas extras.");
                }
                else
                {
                    E = 0;
                    multN = (N * 10);
                    Console.WriteLine($"O funcionário código |{C}| receberá |R${multN:F2}| e mais |R${E:F2}| de horas extras.");
                }


                Console.Write("Deseja encerrar o programa? (Se sim digite a tecla 's')");
                string input = Console.ReadLine();
                Console.Clear();

                if (input.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                return;
                }
                
                Console.ReadKey();
            }
        }
    }
}
