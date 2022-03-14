using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        public Unit2 unit;
        private string typeOfunit;
        private int value;

        [SetUp]
        public void Setup()
        {
            unit = new Unit2(typeOfunit, value);
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
            string typeOfunit = "character";
            int value = 6;

            Unit2 player = new Unit2("character", value);


            Assert.AreNotEqual(unit.player.value, 0);
        }
        [TestMethod]
        public void AsignaJugadorATorre()

        {


        }
        [TestMethod]
        public void EnfrentaAPersonajes()

        {
            //Enemigo vs jugador gana jugador
            string typeOfunit;
            int value;
            Unit2 player = new Unit2("character", value);
            Unit2 enemy = new Unit2("character", value, false);
            Assert.IsTrue();



        }
        [TestMethod]
        public void SimularCombate()

        {

        }
        [TestMethod]
        public void JugadorpierdeunaVida()

        {

        }
    }
}