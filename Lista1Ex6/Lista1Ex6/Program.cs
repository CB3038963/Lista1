using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeiro;
            double segundo;
            Console.Write("Digite o Primeiro valor: ");
            primeiro = double.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo valor: ");
            segundo = double.Parse(Console.ReadLine());

            double multi = primeiro * segundo;
            double geometrica = Math.Sqrt(multi);

            Console.WriteLine("A a media geometrica desses 2 valores sera {0}", geometrica);


        }
    }
}
