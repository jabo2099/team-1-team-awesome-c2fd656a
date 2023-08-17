using NUnit.Framework;
using levelup;

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
    }
}