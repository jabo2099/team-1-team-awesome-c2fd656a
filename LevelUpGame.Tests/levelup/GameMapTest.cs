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
        public void IsPositionValid()
        {
            var p = new Point(0,0);
            Assert.True(testObj.isPositionValid(p));
        }

        [Test]
        public void ArePositionsInitialized()
        {
            // TODO: Fix this later
            Assert.IsNull(testObj.GetPositions());
        }

    }
}