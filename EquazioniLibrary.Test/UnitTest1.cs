using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EquazionePrimoGradoDeterminata1()
        {
            double a = 4;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsDetermined(a);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void EquazionePrimoGradoDeterminata2()
        {
            double a = 0;
            bool risultato_aspettato = false;
            bool risultato_effettivo = Equazioni.IsDetermined(a);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void EquazionePrimoGradoDeterminata3()
        {
            double a = -3;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsDetermined(a);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }

        [TestMethod]
        public void EquazionePrimoGradoImpossibile1()
        {
            double a = 0;
            double b = 0;
            bool risultato_aspettato = false;
            bool risultato_effettivo = Equazioni.IsIncosisted(a, b);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void EquazionePrimoGradoImpossibile2()
        {
            double a = 0;
            double b = 2;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsIncosisted(a, b);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void EquazionePrimoGradoImpossibile3()
        {
            double a = 3;
            double b = 2;
            bool risultato_aspettato = false;
            bool risultato_effettivo = Equazioni.IsIncosisted(a, b);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void EquazionePrimoGradoImpossibile4()
        {
            double a = 6;
            double b = 0;
            bool risultato_aspettato = false;
            bool risultato_effettivo = Equazioni.IsIncosisted(a, b);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void EquazioneSecondoGrado1()
        {
            double a = 6;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsDegree2(a);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void EquazioneSecondoGrado2()
        {
            double a = 0;
            bool risultato_aspettato = false;
            bool risultato_effettivo = Equazioni.IsDegree2(a);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void EquazioneSecondoGrado3()
        {
            double a = -2;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsDegree2(a);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }

        [TestMethod]
        public void CalcoloDelta1()
        {
            double a = 2;
            double b = 0;
            double c = 3;
            double risultato_aspettato = -24;
            double risultato_effettivo = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void CalcoloDelta2()
        {
            double a = 2;
            double b = 1;
            double c = -3;
            double risultato_aspettato = 25;
            double risultato_effettivo = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void CalcoloDelta3()
        {
            double a = 1;
            double b = 2;
            double c = 1;
            double risultato_aspettato = 0;
            double risultato_effettivo = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }

        [TestMethod]
        public void CalcoloSoluzione1()
        {
            double a = 1;
            double b = 2;
            double c = 1;
            string risultato_aspettato = "L'equazione ha una sola soluzione: -1";
            string risultato_effettivo = Equazioni.EquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void CalcoloSoluzione2()
        {
            double a = 2;
            double b = 0;
            double c = 3;
            string risultato_aspettato = "L'equazione è impossibile";
            string risultato_effettivo = Equazioni.EquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void CalcoloSoluzione3()
        {
            double a = 2;
            double b = 1;
            double c = -3;
            string risultato_aspettato = $"L'equazione ha una due soluzioni {-1.5} e {1}";
            string risultato_effettivo = Equazioni.EquazioneSecondoGrado(a, b, c);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }

        [TestMethod]
        public void SoluzionePrimoGrado1()
        {
            double a = 2;
            double b = 1;
            string risultato_aspettato = $"L'equazione è determinata e la soluzione della x è {0.5}";
            string risultato_effettivo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void SoluzionePrimoGrado2()
        {
            double a = 0;
            double b = 0;
            string risultato_aspettato = "L'equazione di primo grado è indeterminata";
            string risultato_effettivo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
        [TestMethod]
        public void SoluzionePrimoGrado3()
        {
            double a = -2;
            double b = 0;
            string risultato_aspettato = "L'equazione di primo grado è impossibile";
            string risultato_effettivo = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
    }
}
