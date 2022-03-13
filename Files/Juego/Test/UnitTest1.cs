using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private Unit2 unit;

        [SetUp]
        public void Setup()
        {
            unit = new Unit2(string typeOfunit, int value);
        }
        [TearDown]
        public void TearDown()
        {
            unit=null;
            //resetear parámetros y volver =null
        }

        [TestMethod]
        public void CreaTorre()

        {
            // Crear una torre con n niveles. Las torres siempre deben tener al menos un nivel
            //Instanciar la torre
        }
        [TestMethod]
        public void CreaPersonajeValorinicial()
        {

        }
        [TestMethod]
        public void AsignaJugadorATorre()

        {

        }
        [TestMethod]
        public void EnfrentaAPersonajes()

        {

            

        }
        [TestMethod]
        public void SimularCombate()

        {

        }
    }
}