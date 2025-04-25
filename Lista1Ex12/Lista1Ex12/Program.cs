using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto1;
            double produto2;
            double produto3;    
            double produto4;
            double produto5;

            Console.Write("Digite o valor do produto: ");
            produto1 = double.Parse(Console.ReadLine());    
            Console.Write("Digite o valor do produto: ");
            produto2 = double.Parse(Console.ReadLine());    
            Console.Write("Digite o valor do produto: ");
            produto3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do produto: ");
            produto4 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do produto: ");
            produto5 = double.Parse(Console.ReadLine());

            double soma = produto1 + produto2 + produto3 + produto4 + produto5;

            double pagamento;
            Console.Write("Digite o valor pago: ");
            pagamento = double.Parse(Console.ReadLine());

            double troco = pagamento - soma;

            Console.WriteLine("O troco referente ao pagamento da compra no valor de {0} sera de {1}.", soma, troco);



        }
    }
}
