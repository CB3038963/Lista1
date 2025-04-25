using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baze;
            Console.Write("Digite o valor da base do retangulo: ");
            baze = double.Parse(Console.ReadLine());
            double altura;
            Console.Write("Digite o valor da altura do retangulo: ");
            altura = double.Parse(Console.ReadLine());
            double area = baze * altura;
           
            Console.WriteLine("A area total do retangulo de altura {0} e base {1} sera de {2}",altura,baze,area);

        }
    }
}
