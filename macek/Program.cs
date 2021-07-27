using System;
using System.Collections.Generic;

namespace macek
{
    class Program
    {
        static List<Zidle> jidelniZidle;
        static List<Zidle> kancelarskezidle;

        static void Main(string[] args)
        {
            Console.WriteLine("napiste barvu");
            var barvaZidli = Console.ReadLine();

            jidelniZidle = new List<Zidle>();
            kancelarskezidle = new List<Zidle>();

            jidelniZidle.Add(new Zidle("drevo", 0.99f, true, 5, false, "cerna"));
            jidelniZidle.Add(new Zidle("kov", 0.99f, true, 5, false, "bila"));
            jidelniZidle.Add(new Zidle("plast", 0.99f, true, 5, false, "seda"));
            kancelarskezidle.Add(new Zidle("sklo", 0.99f, false, 7, true, "zelena"));

            var vsechnyzidle = Scitanilistu(jidelniZidle, kancelarskezidle);          

            foreach (var zidle in vsechnyzidle)
            {
                zidle.PublikaceBarvy();
            }
        }
        static List<Zidle> Scitanilistu(List<Zidle> zidle1, List<Zidle> zidle2)
        {
            foreach (var zidle in zidle2)
            {
                zidle1.Add(zidle);
            }
            return zidle1;
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
