using System.Drawing;

namespace levelup.cli {
    public class Position {

        private Point _coordinates;

        public Point Coordinates => _coordinates;

        public Position(){
            _coordinates = new Point(0,0);        
        }

        public Position(int xCoordinates, int yCoordinates){
            _coordinates = new Point(xCoordinates, yCoordinates);         
        }
    }
}