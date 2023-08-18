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
            var xCoordinate = _testObj.GetMap().GetStartingPosition().Coordinates.X;
            var yCoordinate = _testObj.GetMap().GetStartingPosition().Coordinates.Y;
            Assert.AreEqual(xCoordinate, _startingPoisition.Coordinates.X);
            Assert.AreEqual(yCoordinate, _startingPoisition.Coordinates.Y);
        }

        [Test]
        public void CheckSetPosition()
        {
            var position = _testObj.GetPosition();
            var newPosition = new Position(1,1);

            _testObj.SetPosition(newPosition);
            position = _testObj.GetPosition();
            Assert.AreEqual(newPosition.Coordinates.X, position.Coordinates.X);
            Assert.AreEqual(newPosition.Coordinates.Y, position.Coordinates.Y);
        }

         [Test]
        public void CheckMoveNorth()
        {
            var beforeMovePosition = _testObj.GetPosition();
            _testObj.Move(GameController.DIRECTION.NORTH);
            var afterMovePosition = _testObj.GetPosition();
            Assert.AreEqual(afterMovePosition.Coordinates.X, beforeMovePosition.Coordinates.X);
            Assert.AreNotEqual(afterMovePosition.Coordinates.Y, beforeMovePosition.Coordinates.Y);
        }
       
        [Test]
        public void CheckMoveWestBounce()
        {
            var beforeMovePosition = _testObj.GetPosition();
            _testObj.Move(GameController.DIRECTION.WEST);
            var afterMovePosition = _testObj.GetPosition();
            Assert.AreEqual(afterMovePosition.Coordinates.X, beforeMovePosition.Coordinates.X);
            Assert.AreEqual(afterMovePosition.Coordinates.Y, beforeMovePosition.Coordinates.Y);
        } 

        [Test]
        public void checkMoveCount()
        {
            var expectedMoveCount = 2;            
            _testObj.Move(GameController.DIRECTION.NORTH);
            _testObj.Move(GameController.DIRECTION.EAST);
            Assert.AreEqual(expectedMoveCount,_testObj.GetMoveCount());
        }
    }
}