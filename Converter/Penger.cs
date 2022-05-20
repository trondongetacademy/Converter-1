using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Penger
    {
        TheOneMethod objTheOneMethod = new TheOneMethod();

        bool status = true;
        double BrukerValg;
        double value;
        double kroner;
        double euro;
        double dollar;
        char FortsetteEllerAvslutte = 'J';

        public void Money()
        {
            Console.WriteLine("Velg 1. for å konvertere kroner til euro 2. for å konvertere kroner til dollar 3. for å konvertere euro til  kroner ");
              Console.WriteLine("4. for å konvertere euro til dollar 5. for å konvertere dollar til kroner 6. for å konvertere dollar til euro");
            BrukerValg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BrukerValg);
            while (status)
            {
                switch (BrukerValg)
                {
                    case 1:
                        Console.WriteLine("Du har valgt Kroner til Euro Konverter. Skriv inn beløp:");
                        kroner = Convert.ToDouble(Console.ReadLine());
                        value = kroner * 0.098;
                        Console.WriteLine(value + " Euro");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 2:
                        Console.WriteLine("Du har valgt Kroner til Dollar Konverter. Skriv inn beløp:");
                        kroner = Convert.ToDouble(Console.ReadLine());
                        value = kroner * 0.10;
                        Console.WriteLine(value + " Dollar");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 3:
                        Console.WriteLine("Du har valgt Euro til Krone Konverter. Skriv inn beløp:");
                        euro = Convert.ToDouble(Console.ReadLine());
                        value = euro * 10.24;
                        Console.WriteLine(value + " Kroner");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 4:
                        Console.WriteLine("Du har valgt Euro til Dollar Konverter. Skriv inn beløp:");
                        euro = Convert.ToDouble(Console.ReadLine());
                        value = euro * 1.05;
                        Console.WriteLine(value + " Dollar");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 5:
                        Console.WriteLine("Du har valgt Dollar til Kroner Konverter. Skriv inn beløp:");
                        dollar = Convert.ToDouble(Console.ReadLine());
                        value = dollar * 9.74;
                        Console.WriteLine(value + " Kroner");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                    case 6:
                        Console.WriteLine("Du har valgt Dollar til Euro Konverter. Skriv inn beløp:");
                        dollar = Convert.ToDouble(Console.ReadLine());
                        value = dollar * 0.95;
                        Console.WriteLine(value + " Euro");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;

                        break;
                }

            }
        }
    }
}
