using NUnit.Framework;
using levelup.cli;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
        }

        [Test]
        public void IsNumPositionsInitialized()
        {
            Assert.AreEqual(100,testObj.numPositions);
        }

        [Test]
        public void IsStartingPositionSet()
        {
            Assert.AreEqual(0,testObj.GetStartingPosition().Coordinates.X);
            Assert.AreEqual(0,testObj.GetStartingPosition().Coordinates.Y);
        }

        

        [Test]
        public void ArePositionsInitialized()
        {
            // TODO: Fix this later
            Assert.IsNull(testObj.GetPositions());
        }

        [Test]
        public void CalculatePositionWithValidMove()
        {
            var start = new Position(1,1);

            var north = testObj.CalculatePosition(start , GameController.DIRECTION.NORTH);
            Assert.AreEqual(1, north.Coordinates.X);
            Assert.AreEqual(2, north.Coordinates.Y);

            var south = testObj.CalculatePosition(start , GameController.DIRECTION.SOUTH);
            Assert.AreEqual(1, south.Coordinates.X);
            Assert.AreEqual(0, south.Coordinates.Y);

            var east = testObj.CalculatePosition(start , GameController.DIRECTION.EAST);
            Assert.AreEqual(2, east.Coordinates.X);
            Assert.AreEqual(1, east.Coordinates.Y);

            var west = testObj.CalculatePosition(start , GameController.DIRECTION.WEST);
            Assert.AreEqual(0, west.Coordinates.X);
            Assert.AreEqual(1, west.Coordinates.Y);
        }

        [Test]
        public void CalculatePositionWithInvalidMove()
        {
            var minPos = new Position(0,0);  // Min South or Min West
            var maxPos = new Position(9,9);  //Max North or Max East

            var bounceNorth = testObj.CalculatePosition(maxPos , GameController.DIRECTION.NORTH);
            Assert.AreEqual(9, bounceNorth.Coordinates.X);
            Assert.AreEqual(9, bounceNorth.Coordinates.Y);

            var bounceSouth = testObj.CalculatePosition(minPos , GameController.DIRECTION.SOUTH);
            Assert.AreEqual(0, bounceSouth.Coordinates.X);
            Assert.AreEqual(0, bounceSouth.Coordinates.Y);

            var bounceWest = testObj.CalculatePosition(minPos , GameController.DIRECTION.WEST);
            Assert.AreEqual(0, bounceWest.Coordinates.X);
            Assert.AreEqual(0, bounceWest.Coordinates.Y);

            var bounceEast = testObj.CalculatePosition(maxPos , GameController.DIRECTION.EAST);
            Assert.AreEqual(9, bounceEast.Coordinates.X);
            Assert.AreEqual(9, bounceEast.Coordinates.Y);
        }

        [Test]
        public void GetTotalPositions() {
            Assert.AreEqual(100,testObj.GetTotalPositions());
        }

    }
}