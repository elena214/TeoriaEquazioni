using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool risposta = false;
            if(a != 0)
            {
                risposta = true;
            }
            return risposta;
        }

        public static bool IsIncosisted(double a, double b)
        {
            bool risposta = false;
            if(a == 0 && b != 0)
            {
                risposta = true;
            }
            return risposta;
        }

        public static bool IsDegree2(double a)
        {
            bool risposta = true;
            if(a == 0)
            {
                risposta = false;
            }
            return risposta;
        }

        public static double Delta(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            return delta;
        }
    }
}
