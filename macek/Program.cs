using System;
using System.Collections.Generic;

namespace macek
{
    class Program
    {
        static List<Zidle> jidelniZidle;

        static void Main(string[] args)
        {
            jidelniZidle = new List<Zidle>();

            jidelniZidle.Add(new Zidle("drevo", 0.99f, true, 5, false));
            jidelniZidle.Add(new Zidle("kov", 0.99f, true, 5, false));

            for (int i = 0; i < jidelniZidle.Count; i++)
            {
                jidelniZidle[i].Publikace();
            }

            foreach (var zidle in jidelniZidle)
            {
                zidle.Publikace();
            }
            /*
                        Console.WriteLine("program na scitani cisel");
                        string textWithoutNumber = "pocet scitancu";
                        var pocetIteraci = Automatizace(textWithoutNumber, false);

                        int vysledek = 0;

                        for (int i = 1; i <= pocetIteraci; i++)
                        {
                            int firstNumber = vysledek;
                            string textWithNumber = "napiste " + i + ". cislo";
                            vysledek = LogickeOperace.Secti(firstNumber, Automatizace(textWithNumber));
                        }

                        Console.WriteLine("vysledek je: " + vysledek);
                    */
        }
        static int Automatizace(string text, bool zaporne = true)
        {
            int number = 0;
            bool isStringNumber = false;

            while (isStringNumber == false)
            {
                Console.WriteLine(text);
                var firstString = Console.ReadLine();
                isStringNumber = int.TryParse(firstString, out number);
                if (isStringNumber == false || (number < 0 && !zaporne))
                {
                    Console.WriteLine("zkuste to znovu");
                }
            }

            return number;
        }

        static void Procvicovani(int x, int y)
        {

        }
        static void ZjisteniCisla()
        {
            int z = 2;
            switch (z)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                default:
                    break;
            }
        }
    }
}
