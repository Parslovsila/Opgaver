using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg13
{
    class trekant
    {

        //Egenskaber  Trekant
        public class Trekant
        {
            public int Grundlinje { get; private set; }
            public int Højde { get; private set; }

            public Trekant(int Grundlinje, int højde)
            {
                this.Grundlinje = Grundlinje;
                this.Højde = højde;
            }

            public double Areal
            {
                get
                {
                    return this.Grundlinje * this.Højde * 0.5;
                }

            }
        }
    }
}
