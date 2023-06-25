using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATIII
{
    internal class Q3
    {
        public Q3()
        {
            int idVendedor, codPeca, qtdeVendida;
            decimal precoUnitPeca, venda, comissao;

                Console.WriteLine("QUESTÃO 03");
                Console.WriteLine("");

                Console.Write("Insira sua identificação: ");
                idVendedor = int.Parse(Console.ReadLine());
                Console.Write("Insira o código da peça: ");
                codPeca = int.Parse(Console.ReadLine());
                Console.Write("Insira o preço unitário da peça: ");
                precoUnitPeca = decimal.Parse(Console.ReadLine());
                Console.Write("Insira a quantidade de peças que foi vendidas: ");
                qtdeVendida = int.Parse(Console.ReadLine());

            venda = precoUnitPeca * qtdeVendida;
            comissao = venda * 0.05m;

            Console.Clear();
            Console.WriteLine($"CÓDIGO DO VENDEDOR: {idVendedor} | CÓDIGO DA PEÇA: {codPeca}");
            Console.WriteLine($"QUANTIDADE DE PEÇAS VENDIDAS: {qtdeVendida}, VALOR UNITÁRIO DAS PEÇAS {precoUnitPeca:F2}");
            Console.WriteLine($"O vendedor vendeu no total {venda} e a comissão que ele(a) vai receber é de {comissao:F2} reais");
            Console.ReadKey();

        }
    }
}
