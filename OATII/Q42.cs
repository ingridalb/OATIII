using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q42
    {
        public Q42()
        {
            int numero;
            int maior = int.MinValue;
            int menor = int.MaxValue;

            do
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > maior)
                        maior = numero;

                    if (numero < menor)
                        menor = numero;
                }
            } while (numero != 0);

            Console.WriteLine($"Maior número: {maior}.");
            Console.WriteLine($"Menor número: {menor}");
            Console.ReadLine();
        }
    }
}
