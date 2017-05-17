using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14
{

    static class ArealBeregninger
    {
     public static double BeregnArealFirkant(double h, double b)
        {
            return h * b;

        }
     public static double BeregnArealCirkel(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(8, 8));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(8));
            Console.ReadKey();


        }
    }
}
