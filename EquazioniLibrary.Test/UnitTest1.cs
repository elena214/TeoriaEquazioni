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
    }
}
