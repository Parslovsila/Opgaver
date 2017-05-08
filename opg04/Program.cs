using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] løn ={95000, 20000, 30000, 40000, 23512};
            Double total = 0;

            Array.Sort(løn);

            for (int i = 0; i < løn.Length; i++)
            {
                total +=løn[i];
                Console.WriteLine(løn[i]);
                }

            Double gennemsnit = total / løn.Length;

            Console.WriteLine(gennemsnit.ToString("C2"));


            Console.ReadKey();

        }
        }
    }

