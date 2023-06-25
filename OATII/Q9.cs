using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q9
    {
        public Q9()
        {
            int idade, meses, dias, anos;

            Console.WriteLine("QUESTÃO 09");
            Console.WriteLine("");

            Console.Write("Digite sua idade em anos, meses e dias, nessa ordem: ");
            anos = int.Parse(Console.ReadLine());
            meses = int.Parse(Console.ReadLine());
            dias = int.Parse(Console.ReadLine());

                idade = (anos * 365) + (meses * 30) + dias;

            Console.Clear();
            Console.WriteLine($"A sua idade em convertida é de: {idade} dias!");
            Console.ReadKey();
        }
    }
}
