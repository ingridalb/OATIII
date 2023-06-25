using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q23
    {
        public Q23()
        {
            int num1, num2, soma, sub, mult, div, escolha;

            do
            {
                Console.WriteLine("QUESTÃO 23");
                Console.WriteLine("");
                Console.WriteLine("Escola uma opção:");
                Console.WriteLine("1. SOMA");
                Console.WriteLine("2. SUBTRAÇÃO");
                Console.WriteLine("3. MULTILPICAÇÃO");
                Console.WriteLine("4. DIVISÃO");
                Console.WriteLine("5. SAIR");

                if (int.TryParse(Console.ReadLine(), out escolha))
                    Console.Clear();

                switch (escolha)
                {
                    case 1:

                        Console.Write("Insira o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        soma = num1 + num2;
                        Console.WriteLine($"A soma dos dois números é: {soma}.");

                        break;

                    case 2:

                        Console.Write("Insira o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        sub = num1 - num2;
                        Console.WriteLine($"A subtração dos dois números é: {sub}.");

                        break;

                    case 3:

                        Console.Write("Insira o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        mult = num1 * num2;
                        Console.WriteLine($"A multiplicação dos dois números é: {mult}");

                    break;

                    case 4:

                        Console.Write("Insira o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        div = num1 / num2;
                        Console.WriteLine($"A divisão dos dois números é: {div}");

                    break;

                    case 5:

                        Console.WriteLine("Até a próxima!");

                    break;

                    default:

                        Console.WriteLine("Opção inválida!");

                    break;


                }
                Console.ReadKey();
                Console.Clear();


            } while (escolha != 5);
            
        }
    }
}
