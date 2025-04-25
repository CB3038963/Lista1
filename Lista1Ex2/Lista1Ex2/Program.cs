using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aresta;
            Console.Write("Digite a aresta do quadrado: ");
            aresta = double.Parse(Console.ReadLine());
            double area = aresta * aresta;
            Console.WriteLine("A area do quadrado sera de {0}.",area);

        }
    }
}
