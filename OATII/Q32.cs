using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q32
    {
        public Q32() 
        {
            int numero, contador = 0, somaQuadrados = 0;
            bool numeroValido = false;

            do
            {
                Console.WriteLine("QUESTÃO 32");
                Console.WriteLine();

                Console.Write("Digite um número maior que zero e menor que 10: ");
                numero = int.Parse(Console.ReadLine());
                Console.Clear();

                if (numero > 0 && numero < 10)
                {
                    numeroValido = true;
                }
                else
                {
                    Console.WriteLine("Número inválido!");
                }
            } while (!numeroValido);

            for (int i = numero; contador < 20; i += 2)
            {
                somaQuadrados += i * i;
                contador++;
            }

            Console.Clear();
            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares a partir de {numero} é: {somaQuadrados}");
            Console.ReadLine();
        }
    }
}
