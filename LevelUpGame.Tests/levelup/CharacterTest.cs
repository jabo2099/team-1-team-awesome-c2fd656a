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
            testObj.SetPosition(startingPoisition);
        }

        [Test]
        public void IsNameAvailable()
        {
            Assert.IsNotNull(testObj.GetName());
        }

        [Test]
        public void CheckDefaultCharacterName()
        {
            Assert.AreEqual(DEFAULT_CHARACTER_NAME,testObj.GetName());
        }

        [Test]
        public void CheckCharacterName()
        {
            Character? testObj = new Character("NOT DEFAULT");
            Assert.AreEqual(testObj.GetName(),"NOT DEFAULT");
            Assert.AreNotEqual(DEFAULT_CHARACTER_NAME,testObj.GetName());
        }

        [Test]
        public void CheckEnterMap()
        {
            Assert.AreEqual(testMap,testObj.GetMap());
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
        public void CheckMoveNorth()
        {
            var beforeMovePosition = testObj.GetPosition();
            testObj.Move(GameController.DIRECTION.NORTH);
            var afterMovePosition = testObj.GetPosition();
            Assert.AreEqual(afterMovePosition.XCoordinates, beforeMovePosition.XCoordinates);
            Assert.AreNotEqual(afterMovePosition.YCoordinates, beforeMovePosition.YCoordinates);
        }
       /*
        [Test]
        public void CheckMoveWestBounce()
        {
            var beforeMovePosition = testObj.GetPosition();
            testObj.Move(GameController.DIRECTION.WEST);
            var afterMovePosition = testObj.GetPosition();
            Assert.AreEqual(afterMovePosition.XCoordinates, beforeMovePosition.XCoordinates);
            Assert.AreEqual(afterMovePosition.YCoordinates, beforeMovePosition.YCoordinates);
        } */

        [Test]
        public void checkMoveCount()
        {
            var expectedMoveCount = 2;            
            testObj.Move(GameController.DIRECTION.NORTH);
            testObj.Move(GameController.DIRECTION.EAST);
            Assert.AreEqual(expectedMoveCount,testObj.getMoveCount());
        }
    }
}