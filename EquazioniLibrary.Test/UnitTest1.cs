using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EquazionePrimoGradoDeterminata()
        {
            double a = 4;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsDetermined(a);
            Assert.AreEqual(risultato_effettivo, risultato_aspettato);
        }
    }
}
