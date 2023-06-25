using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    public class Q1
    {
        public Q1()
        {
            int estoqueMedio, qtdeMinima, qtdeMaxima;

            Console.WriteLine("QUESTÃO 01");
            Console.Write("");

            Console.Write("Insira a quatidade mínima de roupas: ");
            qtdeMinima = int.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade máxima de roupas: ");
            qtdeMaxima = int.Parse(Console.ReadLine());

            estoqueMedio = qtdeMinima + qtdeMaxima / 2;

            Console.Clear();
            Console.Write($"O estoque médio de roupas no estoque é: {estoqueMedio}");
            Console.ReadKey();

        }
    }



}
