using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class TheOneMethod
    {

        public char FortsetteEllerAvslutte;
        public bool tOrF;
        public bool isTrueOrNot;

        public void TheMethod()
        {
            Console.WriteLine("Ønsker du å fortsette? eller vil du velge en annen kalkulator?");
            Console.WriteLine("Trykk \'J\' for JA, eller \'N\' for NEI.");
            FortsetteEllerAvslutte = Convert.ToChar(Console.ReadLine());
            if (FortsetteEllerAvslutte == 'N')
            {
                tOrF = false;
            }
            else
            {
                tOrF = true;
            }
           
        }

        public TheOneMethod()
        {
            isTrueOrNot = tOrF;
        }
        
    }
}
