using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q50
    {
        public Q50()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(100);
            int tentativas = 0;

            Console.WriteLine("QUESTÃO 50");
            Console.WriteLine();

            Console.WriteLine("JOGO: ADIVINHE O NÚMERO");
            Console.WriteLine("-----------------------");


            while (true)
            {
                Console.Write("Informe sua tentativa: ");
                int tentativa = int.Parse(Console.ReadLine());
                tentativas++;

                Console.Clear();

                if (tentativa == numeroSorteado)
                {
                    Console.WriteLine($"Você acertou! O número é {numeroSorteado} você fez {tentativas} tentativas.");
                    break;
                }
                else if (tentativa < numeroSorteado)
                {
                    Console.WriteLine("O número sorteado é maior que a sua tentativa.");
                }
                else
                {
                    Console.WriteLine("O número sorteado é menor que a sua tentativa.");
                }
            }

            Console.ReadKey();
        }
    }
}
