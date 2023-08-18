
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
        public void PositionHasXCoordinates() {
            Assert.AreEqual(XCOORDINATES,_position.Coordinates.X);
        }

        [Test]
        public void PositionHasYCoordinates() {
            Assert.AreEqual(YCOORDINATES,_position.Coordinates.Y);
        }
        
    
    }

}