using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q35
    {
        public Q35()
        {
            Console.WriteLine("QUESTÃO 35");
            Console.WriteLine();

            int var1 = 1, var2 = 200;
            

            Console.WriteLine("QUESTÃO 35");
            Console.WriteLine();

            for (int i = var1; i <= var2; i++)
            {
                string mensagem = "";

                if (i % 10 == 0)
                {
                    mensagem = "é divisível por 10!";
                }

                Console.WriteLine(i + " " + mensagem);

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
