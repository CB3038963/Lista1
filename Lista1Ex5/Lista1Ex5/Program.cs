using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double um;
            double dois;
            double tres;
            double quatro;
           
            Console.Write("Digite o 1° valor: ");
            um = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2° valor: ");
            dois = double.Parse(Console.ReadLine());
            Console.Write("Digite o 3° valor: ");
            tres = double.Parse(Console.ReadLine());
            Console.Write("Digite o 4° valor: ");
            quatro = double.Parse(Console.ReadLine());

            double media = um + dois + tres + quatro/4;

            Console.WriteLine("A media da soma desses 4 valores sera de {0}.", media);

        }
    }
}
