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
            Assert.AreEqual(0,testObj.GetStartingPosition().XCoordinates);
            Assert.AreEqual(0,testObj.GetStartingPosition().YCoordinates);
        }

        

        [Test]
        public void ArePositionsInitialized()
        {
            // TODO: Fix this later
            Assert.IsNull(testObj.GetPositions());
        }

        [Test]
        public void calculatePositionWithValidMove()
        {
            var start = new Position(1,1);

            var north = testObj.calculatePosition(start , GameController.DIRECTION.NORTH);
            Assert.AreEqual(1, north.XCoordinates);
            Assert.AreEqual(2, north.YCoordinates);

            var south = testObj.calculatePosition(start , GameController.DIRECTION.SOUTH);
            Assert.AreEqual(1, south.XCoordinates);
            Assert.AreEqual(0, south.YCoordinates);

            var east = testObj.calculatePosition(start , GameController.DIRECTION.EAST);
            Assert.AreEqual(2, east.XCoordinates);
            Assert.AreEqual(1, east.YCoordinates);

            var west = testObj.calculatePosition(start , GameController.DIRECTION.WEST);
            Assert.AreEqual(0, west.XCoordinates);
            Assert.AreEqual(1, west.YCoordinates);
        }

[Test]
        public void calculatePositionWithInvalidMove()
        {
            var minPos = new Position(0,0);  // Min South or Min West
            var maxPos = new Position(9,9);  //Max North or Max East

            var bounceNorth = testObj.calculatePosition(maxPos , GameController.DIRECTION.NORTH);
            Assert.AreEqual(9, bounceNorth.XCoordinates);
            Assert.AreEqual(9, bounceNorth.YCoordinates);

            var bounceSouth = testObj.calculatePosition(minPos , GameController.DIRECTION.SOUTH);
            Assert.AreEqual(0, bounceSouth.XCoordinates);
            Assert.AreEqual(0, bounceSouth.YCoordinates);

            var bounceWest = testObj.calculatePosition(minPos , GameController.DIRECTION.WEST);
            Assert.AreEqual(0, bounceWest.XCoordinates);
            Assert.AreEqual(0, bounceWest.YCoordinates);

            var bounceEast = testObj.calculatePosition(maxPos , GameController.DIRECTION.EAST);
            Assert.AreEqual(9, bounceEast.XCoordinates);
            Assert.AreEqual(9, bounceEast.YCoordinates);
        }

    }
}