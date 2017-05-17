using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15
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
        public string Fuldtnavn()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }
    public class Elev : person
    {
     public string KlasseLokale
        {
            get; set;
        }
        
    }
    public class Instruktør : person
    {
        public int NøgleId
        {
            get; set;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            person p = new person()
            {
                Efternavn = "x",
                Fornavn = "y"
            };
            Elev e = new Elev()
            {
                Efternavn = "t",
                Fornavn = "g",
                KlasseLokale = "a"
            };
            Instruktør i = new Instruktør()
            {
                Efternavn = "2",
                Fornavn = "s",
                NøgleId = 1
            };

            person p1 =new person { Efternavn = "Parslov", Fornavn = "Janus" };
            

            
            Console.WriteLine("Person: " + p.Fuldtnavn());
            Console.WriteLine("Ny Person: " + p1.Fuldtnavn());
            Console.WriteLine("Elev: " +e.Fuldtnavn());
            Console.WriteLine("instruktør: "+i.Fuldtnavn());
            Console.ReadKey();
            
    }
    }
}
