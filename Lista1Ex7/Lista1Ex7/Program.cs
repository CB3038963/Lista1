using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double milhasM;
            Console.Write("Digite quantas milhas maritimas deseja converter em KM: ");
            milhasM = double.Parse(Console.ReadLine());

            double KM = 1000;

            double convert = milhasM * KM;

            Console.WriteLine("{0} milhas maritimas equivale a {1}Km.", milhasM,convert);

        }
    }
}
