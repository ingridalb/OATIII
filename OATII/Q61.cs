using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q61
    {
        public Q61()
        {
            Console.WriteLine("QUESTÃO 61");
            Console.WriteLine("----------");
            Console.Write("Informe o valor do salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Informe o índice de reajuste: ");
            double indiceReajuste = double.Parse(Console.ReadLine());

            double salarioAtualizado = Reajuste(salario, indiceReajuste);

            Console.Clear();
            Console.WriteLine($"O valor salário atualizado é: {salarioAtualizado}");
            Console.ReadKey();
        }

        static double Reajuste(double salario, double indiceReajuste)
        {
            double salarioAtualizado = salario + (salario * (indiceReajuste / 100));
            return salarioAtualizado;
        }
    }
}
