using System.Drawing;

namespace levelup.cli {
    public class Position {

        private int _xCoordinates = 0;
        private int _yCoordinates = 0;
        private Point _coordinates;

        public int XCoordinates => _xCoordinates;
        public int YCoordinates => _yCoordinates;
        public Point Coordinates => _coordinates;

        public Position(){
            _coordinates = new Point(_xCoordinates, _yCoordinates);        
        }

        public Position(int xCoordinates, int yCoordinates){
            _xCoordinates = xCoordinates;
            _yCoordinates = yCoordinates;
            _coordinates = new Point(xCoordinates, yCoordinates);
        }
    }
}