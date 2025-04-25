using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            Console.Write("Digite o valor da diagonal do quadrado: ");
            diagonal = double.Parse(Console.ReadLine());

            double exp2 = 2;
            double quad = Math.Pow(diagonal, exp2);
            double area = quad / 2;

            Console.WriteLine("A area do quadrado com diagonal {0} sera de {1}", diagonal, area);
        }
    }
}
