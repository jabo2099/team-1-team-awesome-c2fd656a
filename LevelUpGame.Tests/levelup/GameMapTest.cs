using NUnit.Framework;
using levelup;
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
        public void IsPositionValid()
        {
        #pragma warning disable CS8602 // Rethrow to preserve stack details

        var p = new Point(0,0);

            Assert.True(testObj.isPositionValid(p));
        }

    }
}