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

        [Test]
        public void CheckSetPosition()
        {
            var position = testObj.GetPosition();
            var newPosition = new Position(1,1);

            testObj.SetPosition(newPosition);
            position = testObj.GetPosition();
            Assert.AreEqual(newPosition.XCoordinates, position.XCoordinates);
            Assert.AreEqual(newPosition.YCoordinates, position.YCoordinates);
        }
        
        [Test]
        public void CheckCalculatePosition()
        {
            var position = new Position(0,0);

            var newPosition = testObj.GetMap().calculatePosition(position, GameController.DIRECTION.NORTH);
            Assert.AreEqual(newPosition.XCoordinates, 0);
            Assert.AreEqual(newPosition.YCoordinates, 1);
        }

        [Test]
        public void CheckMove()
        {
            testObj.SetPosition(new Position(0,0));
            testObj.Move(GameController.DIRECTION.NORTH);
            var newPosition = testObj.GetPosition();
            Assert.AreEqual(newPosition.XCoordinates, 0);
            Assert.AreEqual(newPosition.YCoordinates, 1);
        }
    }
}