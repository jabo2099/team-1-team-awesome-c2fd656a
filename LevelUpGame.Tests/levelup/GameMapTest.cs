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
        public void IsNumPositionsInitializedIs()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.AreEqual(100,testObj.numPositions);
        }

        [Test]
        public void IsStartingPositionSet()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.AreEqual(0,testObj.GetStartingPosition().XCoordinates);
            Assert.AreEqual(0,testObj.GetStartingPosition().YCoordinates);
        }
        [Test]
        public void IsPositionValid()
        {
        #pragma warning disable CS8602 // Rethrow to preserve stack details
        var p = new Point(0,0);

            Assert.True(testObj.isPositionValid(p));
        }

    }
}