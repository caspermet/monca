using System;
using System.Collections.Generic;
using System.Text;

namespace macek
{
    static class LogickeOperace
    {
        public static int Secti(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            return result;
        }

        static float Desetiny()
        {
            return 0.1f;
        }

        static bool ScitaniFloatu(float x, float y)
        {
            float soucet = x + y;
            if (soucet >= 0)
                return true;

            return false;
        }

        static void Nasob(int kusy, float cena)
        {
            float nasobek = (float)kusy * cena;
            Console.WriteLine("vysledek je " + nasobek);
        }
    }
}
