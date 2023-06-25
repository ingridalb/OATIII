using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q5
    {
        public Q5 ()
        {
            decimal distancia, tempo, velocidade, litros_usados;

            Console.WriteLine("QUESTÃO 05");
            Console.WriteLine();

            Console.Write("Insira as horas gastas na viagem: ");
            tempo = decimal.Parse(Console.ReadLine());
            Console.Write("Insira a velocidade média que você dirigiu: ");
            velocidade = decimal.Parse(Console.ReadLine());

                distancia = tempo * velocidade;
                litros_usados = distancia / 12;

            Console.Clear();
            Console.WriteLine($"Você gastou {tempo:F2} horas na estrada, estava na velocidade média de {velocidade} por hora, " +
                $"percorreu {distancia} KM e consumiu {litros_usados:F2} litros de gasolina!");
            Console.ReadKey();
        }
    }
}
