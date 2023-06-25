using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q51
    {
        public Q51()
        {
            int qtdeAlunos,maiorSete = 0;
            double somaNotas = 0, media;

            Console.WriteLine("QUESTÃO 51");
            Console.WriteLine();

            Console.Write("Informe a quantidade de alunos: ");
            qtdeAlunos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdeAlunos; i++)
            {
                Console.Write($"Digite a nota do aluno {i}: ");
                double nota = double.Parse(Console.ReadLine());

                somaNotas += nota;

                if (nota > 7.0)
                {
                    maiorSete++;
                }
            }

            media = somaNotas / qtdeAlunos;
            Console.WriteLine($"Média das notas: {media:F2}");

            if (maiorSete > 0)
            {
                Console.WriteLine($"Alunos com média acima de 7: {maiorSete}");
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno com média acima de 7.");
            }

            Console.ReadKey();
        }
    }
}
