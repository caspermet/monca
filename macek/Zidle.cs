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

        public Zidle(string material, float cena, bool operadlo, int pocetNohou, bool otocna)
        {
            this.material = material;
            this.cena = cena;
            this.operadlo = operadlo;
            this.pocetNohou = pocetNohou;
            this.otocna = otocna;
        }

        public void Publikace()
        {
            Console.WriteLine("material zidle je " + material);
        }
    }
}
