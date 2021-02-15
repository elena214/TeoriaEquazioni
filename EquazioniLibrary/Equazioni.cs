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
    }
}
