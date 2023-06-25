using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q11
    {
        public Q11() 
        {

            int A, B;

            Console.WriteLine("QUESTÃO 11");
            Console.WriteLine("");
            Console.Write("Insira o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"Os valores de A = {A} e B = {B}.");

            (A, B) = (B, A);

            Console.WriteLine($"Os valores trocados de A = {A} e B = {B}");
            Console.ReadKey();
        }
    }
}
