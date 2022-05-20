using System;

namespace Converter
{
    internal class Program
    {
        //public Program()
        //{
        //    Program tilbake = new Program();
        //    void backToMe();
        //}

        static void Main(string[] args)
        {
            TheOneMethod objTheOneMethod = new TheOneMethod();

            bool status = true;
            char SjekkeSumEllerKonverterEllerAvslutt;
            char FortsetteEllerAvslutte = 'J';


            // Lag egen metode for repeterende tekst på filer

            Console.WriteLine("Hei og velkommen til konvertern");
            Console.WriteLine("Velg mellom: 1. Temperatur 2. Penger 3. Hastigheter");
            int brukerValg = Convert.ToInt32(Console.ReadLine());
            
                while (status)
                {
                    switch (brukerValg)
                    {
                        case 1:
                            Console.WriteLine("Du har valgt temperatur kalkualtor");
                            Grader sammenlignTemperature = new Grader();
                            sammenlignTemperature.Temperature();
                            Console.WriteLine("Ønsker du å fortsette? eller vil du velge en annen kalkulator?");
                            Console.WriteLine("Trykk \'J\' for JA, eller \'N\' for NEI.");
                            FortsetteEllerAvslutte = Convert.ToChar(Console.ReadLine());
                        break;
                        case 2:
                            Console.WriteLine("Du har valgt Penge kalkualtor");
                            Penger sammenlignValutaer = new Penger();
                            sammenlignValutaer.Money();
                            Console.WriteLine("Ønsker du å fortsette? eller vil du velge en annen kalkulator?");
                            Console.WriteLine("Trykk \'J\' for JA, eller \'N\' for NEI.");
                            FortsetteEllerAvslutte = Convert.ToChar(Console.ReadLine());
                        break;
                        case 3:
                            Console.WriteLine("Du har valgt hastighet kalkualtor");
                            Hastighet speed = new Hastighet();
                            speed.fart();
                            Console.WriteLine("Ønsker du å fortsette? eller vil du velge en annen kalkulator?");
                            Console.WriteLine("Trykk \'J\' for JA, eller \'N\' for NEI.");
                            FortsetteEllerAvslutte = Convert.ToChar(Console.ReadLine());
                        break;
                    }
                if (FortsetteEllerAvslutte == 'N') status = false;
                }
            
           
           
        
                Console.WriteLine("Vil du sjekke en annen sum, velge en annen konverter eller avslutte? Tast A for Avslutt, K for å bytte konverter, S for å sjekke ny sum");
                SjekkeSumEllerKonverterEllerAvslutt = Convert.ToChar(Console.ReadLine());
                if (SjekkeSumEllerKonverterEllerAvslutt == 'A') status = false;
                if (SjekkeSumEllerKonverterEllerAvslutt == 'K')
                {
                    Console.WriteLine("Velg en av punktene under:");
                    Console.WriteLine("1. Konverter Celcius til Fahrenhet. 2. Konverter Fahrenheit til celcius. 3. Konverter Kroner til Euro. 4. Konverter Kroner til Dollar. 5. Konverter Euro til Kroner. 6. Konverter Euro til Dollar. 7. Konverter Dollar til Kroner. 8. Konverter Dollar til Euro. 9. Promillemåler ");
                    brukerValg = Convert.ToInt32(Console.ReadLine());
                }
            }

        }
    }

