using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q15
    {
        public Q15() 
        {
            double nota1, nota2, nota3, nota4;
            double media, novaMedia, notaRecuperacao;

            Console.WriteLine("QUESTÃO 14");
            Console.WriteLine();

            Console.WriteLine("Informe suas notas:");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7.0)
            {
                Console.WriteLine($"Você foi aprovado com média: {media:F1}!");
            }
            else
            {
                Console.WriteLine($"Você está de recuperação com média: {media:F1}!");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Digite a nota da sua recuperação:");
                notaRecuperacao = double.Parse(Console.ReadLine());
                novaMedia = (media + notaRecuperacao) / 2;

                Console.Clear();

                if (novaMedia >= 7.0)
                {
                    Console.WriteLine($"Você foi aprovado com média: {novaMedia:F1}!");
                }
                else
                {
                    Console.WriteLine($"Você não foi aprovado, média final: {novaMedia:F1}.");
                }
            }

            Console.ReadKey();
        }

    }
}
