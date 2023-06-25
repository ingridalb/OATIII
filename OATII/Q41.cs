using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q41
    {
        public Q41()
        {

            int idade;

            Console.WriteLine("QUESTÃO 41");
            Console.WriteLine();
            Console.Write("Informe a idade do(a) nadador(a): ");
            idade = int.Parse(Console.ReadLine());
            Console.Clear();

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("O(A) nadador(a) está classificado(a) na categoria 'Infantil A'.");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("O(A) nadador(a) está classificado(a) na categoria 'Infantil B'.");
            }
            else if (idade == 12 || idade == 13)
            {
                Console.WriteLine("O(A) nadador(a) está classificado(a) na categoria 'Juvenil A'.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("O(A) nadador(a) está classificado(a) na categoria 'Juvenil B'.");
            }
            else
            {
                Console.WriteLine("O(A) nadador(a) está classificado(a) na categoria 'Adultos'.");
            }

            Console.ReadKey();
        }
    }
}
