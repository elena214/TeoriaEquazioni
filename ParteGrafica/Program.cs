using System;
using EquazioniLibrary;

namespace ParteGrafica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equazione di primo grado");
            Console.WriteLine("Inserire il valore del coefficiente di x");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserire il termine noto");
            double b1 = Convert.ToDouble(Console.ReadLine());
            string risposta_primoGrado = Equazioni.EquationDegree1(a1, b1);
            Console.WriteLine(risposta_primoGrado);
            Console.WriteLine("Equazione di secondo grado");
            Console.WriteLine("Inserire il valore del coefficiente di x^2");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserire il valore del coefficiente di x");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserire il termine noto");
            double c2 = Convert.ToDouble(Console.ReadLine());
            string risposta_secondoGrado = Equazioni.EquazioneSecondoGrado(a2, b2, c2);
            Console.WriteLine(risposta_secondoGrado);
        }
    }
}
