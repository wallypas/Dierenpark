// 4 uur aan gewerkt.

using System;
using System.Collections.Generic;

namespace Taxi
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine($"Hoeveel KM was de rit?");
            double geredenKM = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hoe laat vertrok je?");
            double startTijd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hoe laat kwam je aan?");
            double eindTijd = Convert.ToDouble(Console.ReadLine());

            double kostenKM = geredenKM * 1;

            double geredenTijd = ((eindTijd - startTijd) / 100) * 60;

            double kostenTijd = (0.00);

            double tijdVoor800 = (0.00);
            double tijdNa1800 = (0.00);


            // Tarief obv tijd
            { 
            if ((startTijd >= 800) && (eindTijd <= 1800))
            {
                kostenTijd = (geredenTijd * 0.25);
            }

            if ((startTijd < 800) && (eindTijd > 1800))
            {
                tijdVoor800 = ((800 - startTijd) / 100) * 60;
                tijdNa1800 = ((eindTijd - 1800) / 100) * 60;
                kostenTijd = ((geredenTijd - (tijdVoor800 + tijdNa1800)) * 0.25) + ((tijdVoor800 + tijdNa1800) * 0.45);
            }
            
            if ((startTijd < 800) && (eindTijd < 1800))
            {
                tijdVoor800 = ((800 - startTijd) / 100) * 60;
                kostenTijd = ((geredenTijd - (tijdVoor800 + tijdNa1800)) * 0.25) + ((tijdVoor800 + tijdNa1800) * 0.45);
            }

            if ((startTijd > 800) && (eindTijd > 1800))
            {
                tijdNa1800 = ((eindTijd - 1800) / 100) * 60;
                kostenTijd = ((geredenTijd - (tijdVoor800 + tijdNa1800)) * 0.25) + ((tijdVoor800 + tijdNa1800) * 0.45);
            }

            if ((startTijd > 1800) && (eindTijd > 1800))
            {
                kostenTijd = (geredenTijd * 0.45);
            }

            if ((startTijd < 800) && (eindTijd < 800))
            {
                kostenTijd = (geredenTijd * 0.45);
            }
            }
            // Weekend tarief

            double kostenSubTotaal = kostenKM + kostenTijd;
            double kostenProcent = (0.00);

            Console.WriteLine($"Op welke dag was de rit?");
            string geredenDag = (Console.ReadLine().ToLower());
            { 
            if (geredenDag.Contains("vrijdag") && (startTijd >= 2200))
            {
                    kostenProcent = ((kostenSubTotaal / 100) * 15);
            }

            if (geredenDag.Contains("zaterdag"))
            {
                    kostenProcent = ((kostenSubTotaal / 100) * 15);
            }

                if (geredenDag.Contains("zondag"))
            {
                    kostenProcent = ((kostenSubTotaal / 100) * 15);
            }

                if ((geredenDag.Contains("maandag")) && (startTijd < 700))
            {
                    kostenProcent = ((kostenSubTotaal / 100) * 15);
            }

            }

            double kostenTotaal = kostenSubTotaal + kostenProcent;


            // Print

            Console.WriteLine($"De kosten zijn €{kostenSubTotaal} voor de rit + een eventueel weekend tarief van €{kostenProcent}.");
            Console.WriteLine($"De totale kosten zijn dus {kostenTotaal}.");
            Console.WriteLine($"De rit was {geredenKM} KM lang en duurde {geredenTijd} minuten.");
            Console.WriteLine($"De KM van de rit koste €{kostenKM} en de tijd koste €{kostenTijd}.");
        }
    }
}



