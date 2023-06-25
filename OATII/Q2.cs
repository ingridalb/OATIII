using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q2
    {
        public Q2()
        {
            double dolar, qtdeDolar, valorDolar, valorReal;
            double real = 4.82;

            Console.WriteLine("QUESTÃO 02");
            Console.WriteLine();

            Console.Write("Insira a cotação do dólar: ");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("Insira quantos dólares você dejesa converter em reais: ");
            qtdeDolar = double.Parse(Console.ReadLine());

            valorDolar = dolar * qtdeDolar;
            valorReal = valorDolar * real;

            Console.WriteLine($"Os dólares convertidos em reais fica: {valorReal:F2}.");
            Console.ReadKey();
        }
    }
}
