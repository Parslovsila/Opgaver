using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg03
{
    
    public enum FilTyper { csv, pdf, txt};

    struct Person
    {
        public int Id;
        public string Navn;
      }
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal+= 20;
            Console.WriteLine(heltal);

            Double tal = 12.5;
            tal++;
            tal--;
            tal *= 2;
            Console.WriteLine(tal);
            
            FilTyper fil = FilTyper.csv;
            Console.WriteLine(fil);
            Console.WriteLine((int)(tal));

            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("ddmmyy"));
            Console.WriteLine(date.ToString("dmy"));
            Console.WriteLine(date.ToLocalTime());
            Console.WriteLine(date.ToLongDateString());

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);
            Console.ReadKey();

            
        }
    }
}
