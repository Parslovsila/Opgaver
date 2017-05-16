using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg07
{
    class Program
    {
        static void Main(string[] args)
        {


            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            double res2 = Areal(5);
            Console.WriteLine(res2);
            Print();
            Print("TEST");
            double res3 = moms(100.35);
            Console.WriteLine(res3);
            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);


            Console.ReadKey();
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double Areal(double radius)
        {
            return (radius * radius) * System.Math.PI;
        }
        static void Print(string text)
        {
            Console.WriteLine(text);
        }
        static void Print()
        {
            Console.WriteLine();
        }
        static double moms(double tal, double momspct = 0.25)
        {
            return tal * momspct;
        }
        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++) { sum += månedsløn[i]; }
            return sum / månedsløn.Length;
        }
    }
}
