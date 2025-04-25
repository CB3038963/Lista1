using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolar = 5.71;
            double real;
            Console.Write("Digite o valor em Real que deseja converte: ");
            real = double.Parse(Console.ReadLine());

            double converte = dolar * real;
            
            Console.WriteLine("R${0} equivale a ${1} em Dolar.",real, converte);
        }
    }
}
