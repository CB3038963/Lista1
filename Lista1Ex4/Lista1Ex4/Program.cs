using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baze;
            Console.Write("Digite a base do triangulo: ");
            baze = double.Parse(Console.ReadLine());

            double altura;
            Console.Write("Digite a altura  do triangulo: ");
            altura = double.Parse(Console.ReadLine());

            double area = baze * altura / 2;

            Console.Write("A area de um triangulo com base {0} e altura {1} sera de {2}", baze, altura, area);
        }
    }
}
