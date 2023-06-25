using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q52
    {
        public Q52()
        {
            int[] vetor = new int[100];
            int tamanho = 0, numero;

            Console.WriteLine("QUESTÃO 52");
            Console.WriteLine("----------");
            Console.WriteLine("Informe um número (se quiser sair, digite -1): ");

            while (tamanho <100)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero == -1)
                    break;

                vetor[tamanho] = numero;
                tamanho++;

                int num1 = 0, num3 = 0, num4 = 0;


                for (int i = 0; i < tamanho; i++)
                {

                    if (vetor[i] == 1)
                        num1++;

                    else if (vetor[i] == 3)
                        num3++;

                    else if (vetor[i] == 4)
                        num4++;
                }

                Console.Clear();
                Console.WriteLine($"Vezes que o número '1' aparece: {num1}");
                Console.WriteLine($"Vezes que o número '3' aparece: {num3}");
                Console.WriteLine($"Vezes que o número '4' aparece: {num4}");

            }
            Console.ReadKey();

        }
        
    }
}
