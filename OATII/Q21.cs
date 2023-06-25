using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q21
    {
        public Q21()
        {

            int A;
            bool sair = true;
            string resposta;

            while (sair)
            {
                Console.WriteLine("QUESTÃO 21");
                Console.WriteLine("");
                Console.WriteLine("Insira o valor de 'A': ");
                Console.WriteLine("Caso queira sair aperte a tecla 'y'.");


                resposta = Console.ReadLine();
                if (resposta.ToLower() == "y")
                {
                    sair = false;
                    continue;
                }
                Console.Clear();

                if (int.TryParse(resposta, out A))
                {
                    if (A >= 0)
                    {
                        Console.WriteLine($"{A}");
                        Console.WriteLine("Esse número é positivo!");
                    }
                    else
                    {
                        Console.WriteLine($"{A}");
                        Console.WriteLine("Esse número é negativo!");
                    }
                }
                Console.ReadKey();
                Console.Clear();
              
            } 
            
        }
    }
}
