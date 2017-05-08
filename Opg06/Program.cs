using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg06
{
    class Program
    {
        static void Main(string[] args)
        {

         for (int i = 1; i < 11; i++)
          {
           for (int x = 1; x < 11; x++)
            {
             int resultat = i * x; if ((i * x) > 50)
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
             Console.Write(resultat.ToString().PadLeft(4));
            }
             Console.WriteLine();
             Console.ReadKey();


            }








        }
    }
}
