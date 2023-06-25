using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q4
    {
        public Q4()
        {
            int A, B, C, D, multAB, multAC, multAD, multBC, multBD, multCD;
            int somaAB, somaAC, somaAD, somaBC, somaBD, somaCD;

            Console.WriteLine("QUESTÃO 04");
            Console.WriteLine();

                Console.Write("Insira o valor de 'A': ");
                A = int.Parse(Console.ReadLine());
                Console.Write("Insira o valor de 'B': ");
                B = int.Parse(Console.ReadLine());
                Console.Write("Insira o valor de 'C': ");
                C = int.Parse(Console.ReadLine());
                Console.Write("Insira o valor de 'D': ");
                D = int.Parse(Console.ReadLine());

                    somaAB = A + B; multAB = A * B;
                    somaAC = A + C; multAC = A * C;
                    somaAD = A + D; multAD = A * D;
                    somaBC = B + C; multBC = B * C;
                    somaBD = B + D; multBD = B * D;
                    somaCD = C + D; multCD = C * D;

                Console.WriteLine("");
                Console.WriteLine($"Somas - AB = {somaAB}, AC = {somaAC}, AD = {somaAD}, BC = {somaBC}, BD= {somaBD}, CD = {somaCD}");
                Console.WriteLine($"Multiplicações - AB = {multAB}, AC = {multAC}, AD = {multAD}, BC = {multBC}, BD = {multBD}, CD = {multCD}");
                Console.ReadKey();

        }
    }
}
