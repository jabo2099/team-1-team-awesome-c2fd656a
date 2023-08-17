using System.Drawing;
using levelup.cli;

namespace levelup
{
    public class GameMap {
        public int numPositions=100;
        private Point [,] positions = new Point[10,10];

        private Position startingPosition;

        public GameMap(){
            startingPosition = new Position(0, 0);
        }
        public GameMap(Position startingPos){
            startingPosition = new Position(startingPos.XCoordinates, startingPos.YCoordinates);
        }

        public bool isPositionValid (Point positionCoordinates) {
            return true;
        }
    public Position GetStartingPosition(){
        return startingPosition;
    }
       


    }
}