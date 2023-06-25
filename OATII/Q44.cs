using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q44
    {
        public Q44()
        {

            int escolha;
            decimal C, F, pesoIdeal, h;
            string input;

            do
            {

                Console.WriteLine("QUESTÃO 44");
                Console.WriteLine();

                Console.WriteLine("INSIRA UMA OPÇÃO:");
                Console.WriteLine("1. CONVERSÃO DE GRAUS CELSIUS PARA FAHRENHEIT");
                Console.WriteLine("2. CONVERSÃO DE GRAUS FAHRENHEIT PARA CELSIUS");
                Console.WriteLine("3. PESO IDEAL DO HOMEM");
                Console.WriteLine("4. PESO IDEAL DA MULHER");

                if (int.TryParse(Console.ReadLine(), out escolha))    
                {
                    Console.Clear();
                    switch (escolha)
                    {
                        case 1:
;

                            Console.WriteLine("CONVERSÃO DE GRAUS CELSIUS PARA FAHRENHEIT");
                            Console.WriteLine("");
                            Console.Write("Insira quantos graus está fazendo na sua cidade: ");
                            C = decimal.Parse(Console.ReadLine());

                            F = (9 * C + 160) / 5;

                            Console.Clear();
                            Console.WriteLine($"Na sua cidade está fazendo {C:F2} graus Celsius e {F:F2} graus FahrenHeit.");
                            Console.ReadKey();

                        break;

                        case 2:

                            Console.WriteLine("CONVERSÃO DE GRAUS FAHRENHEIT PARA CELSIUS");
                            Console.WriteLine("");
                            Console.Write("Insira quantos graus está fazendo na sua cidade: ");
                            F = decimal.Parse(Console.ReadLine());

                            C = (F - 32) * 5 / 9;

                            Console.Clear();
                            Console.WriteLine($"Na sua cidade está fazendo {C:F2} graus Fahrenheit e {F:F2} graus Celsius.");
                            Console.ReadKey();

                        break;

                        case 3:
                       
                                Console.WriteLine("Digite a sua altura:");
                                h = decimal.Parse(Console.ReadLine());
                                pesoIdeal = (decimal.Parse("72,7") * h) - 58;
                                Console.WriteLine($"O peso ideal é: {pesoIdeal}");       

                        break;

                        case 4:
                            
                                Console.WriteLine("Digite a sua altura:");
                                h = decimal.Parse(Console.ReadLine());
                                pesoIdeal = (decimal.Parse("62,1") * h) - decimal.Parse("44,7");
                                Console.WriteLine($"O peso ideal é: {pesoIdeal}");

                        break;

                        default:

                         break;
                    }

                    Console.WriteLine();
                    Console.Write("Deseja encerrar o programa? Se sim, digite 's': ");
                    input = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.WriteLine();
                    input = "";
                }

            } while (!input.Equals("s", StringComparison.OrdinalIgnoreCase));

                Console.WriteLine("Até a próxima!.");
                Console.ReadKey();

        }
    }
}
