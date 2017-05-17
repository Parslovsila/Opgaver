using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg16
{

    public class Terning
    {
     private static System.Random rnd;
     private int værdi;
     public int Værdi
        {
         get
            {
                Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
         set
            {

                if (value < 0 || value > 6)
                    value = 1;

                Console.WriteLine("Terning tildeles " + value);
                this.værdi = value;
            }
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }
        public void Ryst()
        {
             this.Værdi = rnd.Next(1, 7);
        }
        public Terning()
        {
            this.Ryst();
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
        static Terning()
        {
            rnd = new Random();
        }


    }

    public class LudoTerning : Terning
    {
        public bool ErGLobus()
        {
            return this.Værdi == 3;
        }
        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
        public LudoTerning():base()
        {

        }
        public LudoTerning(int værdi) : base(værdi)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Terninger Skriv hvad du ønsker at kalde af terninger class: terning, LudoTerning..
            new LudoTerning();
            new Terning();
            new LudoTerning();
            new Terning();
            
            Console.ReadKey();

        }
    }
}
