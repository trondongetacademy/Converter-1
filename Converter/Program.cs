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
      
            bool status = true;
            char SjekkeSumEllerKonverterEllerAvslutt;

            // Lag egen metode for repeterende tekst på filer

            Console.WriteLine("Hei og velkommen til konvertern");
            Console.WriteLine("Velg mellom: 1. Temperatur 2. Penger 3. Hastigheter");
            int brukerValg = Convert.ToInt32(Console.ReadLine());
            back();
            void back()
            {
                while (status)
                {
                    switch (brukerValg)
                    {
                        case 1:
                            Console.WriteLine("Du har valgt temperatur kalkualtor");
                            Grader sammenlignTemperature = new Grader();
                            sammenlignTemperature.Temperature();
                            break;
                        case 2:
                            Console.WriteLine("Du har valgt Penge kalkualtor");
                            Penger sammenlignValutaer = new Penger();
                            sammenlignValutaer.Money();
                            break;
                        case 3:
                            Console.WriteLine("Du har valgt hastighet kalkualtor");
                            Hastighet speed = new Hastighet();
                            speed.fart();
                            break;
                    }
                }
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

