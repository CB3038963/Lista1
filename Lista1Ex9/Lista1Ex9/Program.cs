using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            Console.Write("Digite o diametro do circulo: ");
            diametro = double.Parse(Console.ReadLine());

            double raio = diametro / 2;
            double pi = 3.14;
            double exp2 = 2;
            double raio2 = Math.Pow(raio, exp2);
            double area = pi * raio2;
            Console.WriteLine("A area do circulo com diametro {0} sera de {1}.", diametro, area);        }
    }
}
