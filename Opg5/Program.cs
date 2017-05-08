using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg5
{
    class Program
    {
        static void Main(string[] args)
        {

            // HEKJ
            String ForNavn = "Mikkel";
            String EfterNavn = "Cronberg";
            Console.WriteLine(String.Concat(ForNavn," " , EfterNavn));
            Console.ReadKey();

            String FuldtNavn = (ForNavn +" "+EfterNavn);
            String Stort = FuldtNavn.ToUpper();
            String Lille = FuldtNavn.ToLower();
            Console.WriteLine(Stort);
            Console.ReadKey();

            String del = FuldtNavn.Substring(7, 4);
            Console.WriteLine(del);
            Console.ReadKey();



        }
    }
}
