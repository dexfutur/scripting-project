using NUnit.Framework;
using CollectionAssert = NUnit.Framework.CollectionAssert;

namespace Test
{
    
    public class UnitTest1
    {
        public Unit2 unit;
        private string typeOfunit;
        private int value;

        private DataValidator? validator;


        [SetUp]
        public void Setup()
        {
            unit = new Unit2(typeOfunit, value, victoria:false);
            jugadores = new Jugador(fuerza, aleatorio, value1, resultado, vidas);
            torres = new Torres();
            validator new = DataValidator();
        }
        [TearDown]
        public void TearDown()
        {
            unit=null;
            //resetear parámetros y volver =null
        }

        [Test]
        public void CreaTorre()

        {
            // Crear una torre con n niveles. Las torres siempre deben tener al menos un nivel
            //Instanciar la torre

            
            int Lenght = 5;

            torres = new Torres();


            Assert.AreNotEqual(Torres.Lenght, 0);

        }
        [Test]
        public void CreaPersonajeValorinicial()
        {
            string typeOfunit = "character";
            int value = 6;

            Unit2 player = new Unit2("character", value);


            Assert.AreNotEqual(unit.player.value, 0);
        }
        [Test]
        public void AsignaJugadorATorre()

        {
            torres = new Torres(player1, enemy1);

            Torres.player1 = new player1[1];


            Assert.IsTrue(validator.AreEqual());

        }
        [Test]
        public void EnfrentaAPersonajes()

        {
            //Enemigo vs jugador gana jugador
            string typeOfunit;
            int value;
            Unit2 player = new Unit2("character", value);
            Unit2 enemy = new Unit2("character", value, false);
            Unit2 obstacle = new Unit2("obstacle", value);

            Assert.IsTrue(player.victoria, true);



        }
        [Test]
        public void JugadorVsEnemigoConTorres()

        {
            //Enemigo vs jugador gana jugador
            string typeOfunit;
            int value;

            Torres.player1 = new player1[1];
            Torres.enemy1 = new enemy1[1];

            Unit2 player = new Unit2("character", value);
            Unit2 enemy = new Unit2("character", value, false);
            Unit2 obstacle = new Unit2("obstacle", value);



            Assert.IsTrue(player.victoria, true);
            Assert.IsTrue(enemy.victoria, false);
            CollectionAssert.AreEqual( );



        }
        [Test]
        public void SimularCombate()

        {

        }
        [Test]
        public void JugadorpierdeunaVida()

        {

        }
    }
}