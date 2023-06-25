using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q18
    {
        public Q18  () 
        {

            int CODIGO;

            Console.WriteLine("QUESTÃO 18");
            Console.WriteLine("");
            Console.Write("Insira o número do código: ");
            CODIGO = int.Parse(Console.ReadLine());
            Console.Clear();

            if (CODIGO == 1 || CODIGO == 2 || CODIGO == 3)
            {
                switch (CODIGO)
                {
                    case 1:
                        Console.WriteLine("UM");
                    break;

                    case 2:
                        Console.WriteLine("DOIS");
                    break;

                    case 3:
                        Console.WriteLine("TRÊS");
                    break;
                }
            }
            else 
            {
                Console.WriteLine("Código inválido!");
            }
            Console.ReadKey();
        }
    }
}
