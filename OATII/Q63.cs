using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q63
    {
        public Q63()
        {
            Console.WriteLine("QUESTÃO 63");
            Console.WriteLine("----------");

            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            string resultado = VERIFICA(numero);

            Console.Clear();
            Console.WriteLine($"NÚMERO: '{numero}'.");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        static string VERIFICA (int numero)
        {
            if (numero % 2 == 0)
                return "PAR";
            else
                return "ÍMPAR";
        }
    }
    
}
