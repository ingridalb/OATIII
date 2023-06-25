using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q33
    {
        public Q33()
        {
            decimal soma = 0, media = 0;
            int[] codAlunos = new int[4];
            decimal[] notas = new decimal[4];

            Console.WriteLine("QUESTÃO 33");
            Console.WriteLine();

            for (int i = 0; i <4; i++)
            {
                Console.Write("INSÍRA O CÓDIGO DO ALUNO: ");
                codAlunos[i] = int.Parse(Console.ReadLine());

                Console.Write("INSIRA A NOTA DELE: ");
                notas[i] = decimal.Parse(Console.ReadLine());
                Console.Clear();

                soma += notas[i];
            }

            for (int i = 0; i <4; i++)
            {
                Console.WriteLine($"ALUNO: {codAlunos[i]}| NOTA {notas[i]}");
            }
            
            media = soma / 4;
            Console.WriteLine($"MÉDIA DOS ALUNOS: {media}");
            Console.ReadKey();

        }
    }
}
