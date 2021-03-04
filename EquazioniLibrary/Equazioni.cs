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

        public static string EquazioneSecondoGrado(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            double x1, x2;
            if(delta == 0)
            {
                x1 = -b / (2 * a);
                return $"L'equazione ha una sola soluzione: {x1}";
            }
            else if(delta < 0)
            {
                return "L'equazione è impossibile";
            }
            else
            {
                double soluzione_temporanea;
                x1 = (-b -(Math.Sqrt(delta))) / (2 * a);
                x2 = (-b +(Math.Sqrt(delta))) / (2 * a);
                if(x1 > x2)
                {
                    soluzione_temporanea = x2;
                    x2 = x1;
                    x1 = soluzione_temporanea;
                }
                return $"L'equazione ha una due soluzioni {x1} e {x2}";
            }
        }
        public static string EquationDegree1(double a, double b)
        {
            if(a == 0 && b == 0)
            {
                return "L'equazione di primo grado è indeterminata";
            }
            else if(a != 0 && b == 0)
            {
                return "L'equazione di primo grado è impossibile";
            }
            else
            {
                double soluzione;
                soluzione = b / a;
                return $"L'equazione è determinata e la soluzione della x è {soluzione}";
            }
        }
    }
}
