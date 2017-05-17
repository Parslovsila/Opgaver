using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg17
{
    public class person
    {
        public string Fornavn
        {
            get; set;
        }
        public string Efternavn
        {
            get; set;
        }
        public virtual void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn}");
        }
    }
    public class Elev : person
    {
        public string KlasseLokale
        {
            get; set;
        }
        public override void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn} {KlasseLokale}");
        }

    }
    public class Instruktør : person
    {
        public int NøgleId
        {
            get; set;
        }
        public override void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn} {NøgleId}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Personer 
            person p = new person()
            {
                Efternavn = "X",
                Fornavn = "X"
            };
            person e = new Elev()
            {
                Efternavn = "Z",
                Fornavn = "Z",
                KlasseLokale = "A"
            };
            person i = new Instruktør()
            {
                Efternavn = "X",
                Fornavn = "Y",
                NøgleId = 1
            };

            p.Skriv();
            e.Skriv();
            i.Skriv();

            person[] lst = new person[3];
            lst[0] = p;//Person
            lst[1] = e;//Elev
            lst[2] = i;//Instruktør
            foreach (var item in lst)
                item.Skriv();
            Console.ReadKey();
        }
    }
}
