using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Hastighet
    {

        TheOneMethod objTheOneMethod = new TheOneMethod();

        public double Kmh;
        public double Mph;
        public double Mach;
        public double Knots;
        public double value;
        double BrukerValg;
        bool status = true;
        char FortsetteEllerAvslutte = 'J';


        public void fart()
        {
            Console.WriteLine("Velg 1. for å konvertere Km/t til Mph Velg 2. for å konvertere Km/t til Mach 3. for å konvertere Km/t til Knop ");
            Console.WriteLine("Velg 4. for å konvertere Mph til Km/h Velg 5. for å konvertere Mph til Mach 6. for å konvertere Mph til Knop ");
            Console.WriteLine("Velg 7. for å konvertere Mach til Km/h Velg 8. for å konvertere Mach til Mph. for å konvertere Mach til Knop ");
            Console.WriteLine("Velg 10. for å konvertere Knop til Km/h Velg 11. for å konvertere Knop til Mph 12. for å konvertere Knop til Mach ");


            BrukerValg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BrukerValg);
            while (status)
            {
                switch (BrukerValg)
                {
                    case 1:
                        Console.WriteLine("Du har valgt å Konvertere Km/t til Mph. Skriv inn..");
                        Kmh = Convert.ToDouble(Console.ReadLine());
                        value = Kmh * 0.62;
                        Console.WriteLine(value + " Mph");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 2:
                        Console.WriteLine("Du har valgt å Konvertere Km/t til Mach. Skriv inn..");
                        Kmh = Convert.ToDouble(Console.ReadLine());
                        value = Kmh * 0.0008;
                        Console.WriteLine(value + " Mach");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 3:
                        Console.WriteLine("Du har valgt å Konvertere Km/t til Knop. Skriv inn..");
                        Kmh = Convert.ToDouble(Console.ReadLine());
                        value = Kmh * 0.539957;
                        Console.WriteLine(value + " Knop");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 4:
                        Console.WriteLine("Du har valgt å Konvertere Mph til Km/t. Skriv inn..");
                        Mph = Convert.ToDouble(Console.ReadLine());
                        value = Mph * 1.62;
                        Console.WriteLine(value + " Km/t");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 5:
                        Console.WriteLine("Du har valgt å Konvertere Mph til Mach. Skriv inn..");
                        Mph = Convert.ToDouble(Console.ReadLine());
                        value = Mph * 0.001303;
                        Console.WriteLine(value + " Mach");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 6:
                        Console.WriteLine("Du har valgt å Konvertere Mph til Knop. Skriv inn..");
                        Mph = Convert.ToDouble(Console.ReadLine());
                        value = Mph * 0.868976;
                        Console.WriteLine(value + " Knop");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;

                        break;
                    case 7:
                        Console.WriteLine("Du har valgt å Konvertere Mach til Km/h. Skriv inn..");
                        Mach = Convert.ToDouble(Console.ReadLine());
                        value = Mach * 1234.8;
                        Console.WriteLine(value + " Km/");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 8:
                        Console.WriteLine("Du har valgt å Konvertere Mach til Mph. Skriv inn..");
                        Mach = Convert.ToDouble(Console.ReadLine());
                        value = Mach * 767.269148;
                        Console.WriteLine(value + " Mph");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 9:
                        Console.WriteLine("Du har valgt å Konvertere Mach til Knop. Skriv inn..");
                        Mach = Convert.ToDouble(Console.ReadLine());
                        value = Mach * 666.738661;
                        Console.WriteLine(value + " Knop");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 10:
                        Console.WriteLine("Du har valgt å Konvertere Knop til Km/h. Skriv inn..");
                        Knots = Convert.ToDouble(Console.ReadLine());
                        value = Knots * 1.852;
                        Console.WriteLine(value + " Km/h");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 11:
                        Console.WriteLine("Du har valgt å Konvertere Knop til Mph. Skriv inn..");
                        Knots = Convert.ToDouble(Console.ReadLine());
                        value = Knots * 1.150779;
                        Console.WriteLine(value + " Mph");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 12:
                        Console.WriteLine("Du har valgt å Konvertere Knop til Mach. Skriv inn..");
                        Knots = Convert.ToDouble(Console.ReadLine());
                        value = Knots * 0.0015;
                        Console.WriteLine(value + " Mach");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                }

            }
        }
    }
}





