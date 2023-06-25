using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q53
    {
        public Q53() 
        {
            int N;

            Console.WriteLine("QUESTÃO 53");
            Console.WriteLine("");

            Console.Write("Informe a quantidade de voltas que foram dadas na corrida: ");
            N = int.Parse(Console.ReadLine());

            double[] tempos = new double[N];

            Console.Write("Informe os tempos registrados em cada volta na corrida: ");

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Volta {i + 1}: ");
                tempos[i] = double.Parse(Console.ReadLine());
            }

            double melhorTempo = tempos[0];
            int voltaMelhorTempo = 1;
            double somaTempos = tempos[0];

            for (int i = 1; i < N; i++)
            {
                if (tempos[i] < melhorTempo)
                {
                    melhorTempo = tempos[i];
                    voltaMelhorTempo = i + 1;
                }

                somaTempos += tempos[i];
            }

            double tempoMedio = somaTempos / N;

            Console.Clear();
            Console.WriteLine($"Melhor tempo: {melhorTempo}");
            Console.WriteLine($"Volta do melhor tempo: {voltaMelhorTempo}");
            Console.WriteLine($"Tempo médio das voltas: {tempoMedio}");
            Console.ReadKey();

        }
    }
}
