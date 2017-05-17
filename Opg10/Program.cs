using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg10
{   class Terning
    {
        public int værdi;
        public Terning()
        {
            this.værdi = 1;
        }
        public Terning(int værdi)
        {
            this.værdi = værdi ;
        }

    } 
    class Program
    {
        static void Main(string[] args)
        {
            //Terning
            Terning t1;
            t1 = new Terning();
            Console.WriteLine(t1.værdi);
            Terning t2;
            t2 = new Terning(2);
            Console.WriteLine(t2.værdi);
            t2 = t1;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);
            t1.værdi = 1;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);
            t2.værdi = 6;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);

            Console.ReadKey();
        }
    }
}
