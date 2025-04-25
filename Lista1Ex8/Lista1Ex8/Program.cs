using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            Console.Write("Digite quantos graus celsius deseja converter em farenheit: ");
            celsius = double.Parse(Console.ReadLine());

            double farenh = celsius * 1.8 + 32;

            Console.WriteLine("{0}° Graus celsius equivale a {1}° Graus em Farenheit.",celsius,farenh);


        }
    }
}
