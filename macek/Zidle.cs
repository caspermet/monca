using System;
using System.Collections.Generic;
using System.Text;

namespace macek
{
    class Zidle
    {
        string material;
        float cena;
        bool operadlo;
        int pocetNohou;
        bool otocna;
        string barva;

        public Zidle(string material, float cena, bool operadlo, int pocetNohou, bool otocna, string barva)
        {
            this.material = material;
            this.cena = cena;
            this.operadlo = operadlo;
            this.pocetNohou = pocetNohou;
            this.otocna = otocna;
            this.barva = barva;
        }

        public void ZmenaBarvy(string novaBarva)
        {
            barva = novaBarva;
        }

        public void Publikace()
        {
            Console.WriteLine("material zidle je " + material);
        }
        public void PublikaceBarvy()
        {
            Console.WriteLine("barva zidle je " + barva);
        }
    }
}
