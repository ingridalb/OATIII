using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q43
    {
        public Q43()
        {

            ulong totalGraos = 0;
            ulong graosNoQuadro = 1;

            Console.WriteLine("QUESTÃO 43");
            Console.WriteLine();

            for (int quadro = 1; quadro <= 64; quadro++)
            {
                totalGraos += graosNoQuadro;
                graosNoQuadro *= 2;
            }

            Console.WriteLine($"O monge espera um total de {totalGraos} grãos.");
            Console.ReadKey();
        }
          

    }
}
