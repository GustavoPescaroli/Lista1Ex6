using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double y1;
            double raiz;

            Console.WriteLine("valor de x1");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("valor de y1");
            y1 = double.Parse(Console.ReadLine());

            raiz = Math.Sqrt(x1 * y1);
            Console.WriteLine("valor da raiz {0}", raiz);
        }
    }
}
