using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Grader
    {

        TheOneMethod objTheOneMethod = new TheOneMethod();



        public double Celcius;
        public double Fahrenheit;
        public double value;
        double BrukerValg;
        bool status = true;
        char FortsetteEllerAvslutte = 'J';
        char Tilbake = 'N';
        bool rott = true;
       
        

            public void Temperature()
        {
            Console.WriteLine("Velg 1. for å konvertere Celcius til Fahrenheit eller 2. For å konvertere Fahrenheit til Celcius");
           
            BrukerValg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BrukerValg);
            while (status)
            {
                switch (BrukerValg)
                {
                    case 1:
                        Console.WriteLine("Du har valgt å Konvertere Celcius til Fahrenheit. Skriv inn..");
                        Celcius = Convert.ToDouble(Console.ReadLine());
                        value = ((Celcius * 9) / 5) + 32;
                        Console.WriteLine(value + " Fahrenheit");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;

                        break;
                    case 2:
                        Console.WriteLine("Du har valgt å Konvertere Fahrenheit til Celcius. Skriv inn..");
                        Fahrenheit = Convert.ToDouble(Console.ReadLine());
                        value = (Fahrenheit - 32) * 5 / 9;
                        Console.WriteLine(value + " Celcius");
                        objTheOneMethod.TheMethod();
                        status = objTheOneMethod.isTrueOrNot;
                        break;
                }
            }

        } 
    }
}


