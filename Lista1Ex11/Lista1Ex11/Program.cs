using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X;
            Console.Write("Digite o valor de X: ");
            X = double.Parse(Console.ReadLine());   
            double Y;
            Console.Write("Digite o valor de Y: ");
            Y = double.Parse(Console.ReadLine());

            double calculo = Math.Pow(X,Y);

            Console.WriteLine("Quando X:{0} e é elevado a Y:{1} sera de {2}.",X,Y,calculo);
            
        }
    }
}
