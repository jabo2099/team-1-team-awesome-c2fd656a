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
        private Character? _testObj;
        private GameMap? _testMap;
        private Position? _startingPoisition;


        [SetUp]
        public void SetUp()
        {
            _testObj = new Character();
            _testMap = new GameMap();
            _testObj.SetMap(_testMap);
            _startingPoisition = new Position(xCoordinate, yCoordinate);
            _testObj.SetPosition(_startingPoisition);
        }

        [Test]
        public void IsNameNotAvailable()
        {
            Assert.IsNull(_testObj.GetName());
        }
        
        [Test]
        public void CheckCharacterName()
        {
            Character? testObj = new Character("NOT DEFAULT");
            Assert.AreEqual("NOT DEFAULT",testObj.GetName());            
        }

        [Test]
        public void CheckEnterMap()
        {
            Assert.AreEqual(_testMap,_testObj.GetMap());
        }

        [Test]
        public void CheckStartingPosition()
        {
            var xCoordinate = _testObj.GetMap().GetStartingPosition().XCoordinates;
            var yCoordinate = _testObj.GetMap().GetStartingPosition().YCoordinates;
            Assert.AreEqual(xCoordinate, _startingPoisition.XCoordinates);
            Assert.AreEqual(yCoordinate, _startingPoisition.YCoordinates);
        }

        [Test]
        public void CheckSetPosition()
        {
            var position = _testObj.GetPosition();
            var newPosition = new Position(1,1);

            _testObj.SetPosition(newPosition);
            position = _testObj.GetPosition();
            Assert.AreEqual(newPosition.XCoordinates, position.XCoordinates);
            Assert.AreEqual(newPosition.YCoordinates, position.YCoordinates);
        }

         [Test]
        public void CheckMoveNorth()
        {
            var beforeMovePosition = _testObj.GetPosition();
            _testObj.Move(GameController.DIRECTION.NORTH);
            var afterMovePosition = _testObj.GetPosition();
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
            _testObj.Move(GameController.DIRECTION.NORTH);
            _testObj.Move(GameController.DIRECTION.EAST);
            Assert.AreEqual(expectedMoveCount,_testObj.getMoveCount());
        }
    }
}