using NUnit.Framework;
using levelup;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        static string DEFAULT_CHARACTER_NAME = "TEAM AWESOME";
        static int xCoordinate = 0;
        static int yCoordinate = 0;
        private Character? testObj;
        private GameMap? testMap;
        private Position? startingPoisition;


        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
            testMap = new GameMap();
            testObj.SetMap(testMap);
            startingPoisition = new Position(xCoordinate, yCoordinate);
        }

        [Test]
        public void IsNameAvailable()
        {
            Assert.IsNotNull(testObj.GetName());
        }

        [Test]
        public void CheckDefaultCharacterName()
        {
            Assert.AreEqual(testObj.GetName(),DEFAULT_CHARACTER_NAME);
        }

        [Test]
        public void CheckCharacterName()
        {
            Character? testObj = new Character("NOT DEFAULT");
            Assert.AreEqual(testObj.GetName(),"NOT DEFAULT");
            Assert.AreNotEqual(testObj.GetName(),DEFAULT_CHARACTER_NAME);
        }

        [Test]
        public void CheckEnterMap()
        {
            Assert.AreEqual(testObj.GetMap(),testMap);
        }

        [Test]
        public void CheckStartingPosition()
        {
            var xCoordinate = testObj.GetMap().GetStartingPosition().XCoordinates;
            var yCoordinate = testObj.GetMap().GetStartingPosition().YCoordinates;
            Assert.AreEqual(xCoordinate, startingPoisition.XCoordinates);
            Assert.AreEqual(yCoordinate, startingPoisition.YCoordinates);
        }
    }
}