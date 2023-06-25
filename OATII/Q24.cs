using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q24
    {
        public Q24()
        {
            int escolha, num1, num2;
            double media;

            do
            {
                Console.WriteLine("QUESTÃO 24");
                Console.WriteLine("");

                Console.WriteLine("INSIRA UMA OPÇÃO");
                Console.WriteLine("1. Verificar se os números lidos são múltiplos um do outro.");
                Console.WriteLine("2. Verificar se os números lidos são pares.");
                Console.WriteLine("3. Verificar se a média dos dois números é maior que 7.");
                Console.WriteLine("4. Sair.");
                    if (int.TryParse(Console.ReadLine(), out escolha))
                    Console.Clear();

                switch (escolha)
                {
                    case 1:
                        Console.Write("Insira o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        if (num1 % num2 == 0 || num2 % num1 == 0)
                        {
                            Console.WriteLine("Um dos números é múltiplo do outro!");
                            Console.ReadKey();
                        }
                        else 
                        {
                            Console.WriteLine("Nenhum dos dois números é múltiplo pelo outro!");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    break;

                    case 2:
                        Console.Write("Insira o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        if (num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("Ambos os números são pares!");
                        }
                        else if (num1 % 2 == 0 || num2 % 2 == 0)
                        {
                            Console.WriteLine("Apenas um dos números é par!");
                            Console.ReadKey();
                        }
                        else 
                        {
                            Console.WriteLine("Nenhum dos dois números é par!");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    break;

                    case 3:

                        Console.Write("Insira o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Insira o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());

                        media = num1 + num2 /2;

                        if (media > 7)
                        {
                            Console.WriteLine("A média dos dois números é maior que 7");
                            Console.ReadKey();
                        }
                        else 
                        {
                            Console.WriteLine("A média dos dois números não é maior que 7!");
                            Console.ReadKey();
                        }
                        Console.Clear();
                    break;

                    case 4:
                            Console.WriteLine("Até breve!");
                            Console.ReadKey();
                            Console.Clear();
                    break;

                    default:
                            Console.WriteLine("Insira uma opção válida!");
                    break;
                }
            } while (escolha !=4);

            Console.ReadKey();

        }
        
    }
}
