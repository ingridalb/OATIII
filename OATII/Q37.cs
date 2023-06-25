using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q37
    {
        public Q37()
        {
            int num1 = 0, num2 = 0, soma, sub, mult, div, escolha;

            do
            {
                Console.WriteLine("QUESTÃO 23");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. SOMA");
                Console.WriteLine("2. SUBTRAÇÃO");
                Console.WriteLine("3. MULTIPLICAÇÃO");
                Console.WriteLine("4. DIVISÃO");
                Console.WriteLine("DIGITE 'S' PARA VOLTAR AO MENU PRINCIPAL");

                string input = Console.ReadLine();

                if (input.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                if (int.TryParse(input, out escolha))
                {
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

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite novamente.");
                }

                Console.ReadKey();
                Console.Clear();
            } while (escolha != 4);
        }
    }
}
