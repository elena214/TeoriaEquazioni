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
            double delta = Equazioni.Delta(a, b, c);
            double x1 = 0, x2 = 0;
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
                Equazioni.CalcoloSoluzioni(a, b, ref x1, ref x2, delta);
                Equazioni.CambioVariabili(ref x1, ref x2);
                return $"L'equazione ha una due soluzioni {x1} e {x2}";
            }
        }
        public static void CalcoloSoluzioni(double a, double b, ref double x1, ref double x2, double delta)
        {
            x1 = (-b - (Math.Sqrt(delta))) / (2 * a);
            x2 = (-b + (Math.Sqrt(delta))) / (2 * a);
        }
        public static string EquationDegree1(double a, double b)
        {
            if(a == 0 && b == 0)
            {
                return "L'equazione di primo grado è indeterminata";
            }
            else if(a == 0 && b != 0)
            {
                return "L'equazione di primo grado è impossibile";
            }
            else
            {
                double soluzione;
                soluzione = -b / a;
                return $"L'equazione è determinata e la soluzione della x è {soluzione}";
            }
        }
        public static void CambioVariabili(ref double x1, ref double x2)
        {
            double soluzione_temporanea;
            if(x1 > x2)
            {
                soluzione_temporanea = x1;
                x1 = x2;
                x2 = soluzione_temporanea;
            }
        }
    }
}
