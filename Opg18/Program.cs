using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg18
{
    class Dyr
    {
        static System.Random rnd = new Random();
        public string Navn
        {
            get; set;
        }
        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et Dyr og Hedder " + Navn);
        }
        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\Michell\Filer\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navne.Length);
            if (index % 2== 0 )
            {
                return new Hund()
                {
                    Navn = navne[index]
                };
            }
            else
                return new Kat()
                {
                    Navn = navne[index]
                };

        }
    }

    class Hund : Dyr
    {
     public override void SigNoget()
        {
            Console.WriteLine("Jeg er en Hund og hedder " + Navn);
        }
    }
    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en Kat og hedder " + Navn);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //DYR
            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr) 

            {
                item.SigNoget();
            }
            
            Console.ReadKey();

        }
    }
}
