
using levelup.cli;
using NUnit.Framework;

namespace levelup {
    [TestFixture]
    public class PositionTest {
        private Position _position;
        private readonly  int XCOORDINATES = 0;
        private readonly  int YCOORDINATES = 0;

        [SetUp]
        public void SetUp() {
            _position = new Position(XCOORDINATES, YCOORDINATES);
        }

        [Test]
        public void TestPositionHasXCoordinates() {
            Assert.AreEqual(XCOORDINATES,_position.XCoordinates);
        }

        [Test]
        public void TestPositionHasYCoordinates() {
            Assert.AreEqual(YCOORDINATES,_position.YCoordinates);
        }
        
    
    }

}