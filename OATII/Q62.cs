using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OATII
{
    internal class Q62
    {
        public Q62()
        {
            Console.WriteLine("QUESTÃO 62");
            Console.WriteLine("----------");

            Console.Write("Informe a base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            double hipotenusa = Hipotenusa(baseTriangulo, alturaTriangulo);

            Console.Clear();
            Console.WriteLine($"Valor da hipotenusa: {hipotenusa}");
            Console.ReadKey();
        }

        static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
            return hipotenusa;
        }
    }
    
}
