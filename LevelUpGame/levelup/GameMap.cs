using System.Drawing;

namespace levelup
{
    public class GameMap {
        public int numPositions=100;
        private Point [,] positions = new Point[10,10];

        public bool isPositionValid (Point positionCoordinates) {
            return true;
        }
    }
}