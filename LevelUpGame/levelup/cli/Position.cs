using System.Drawing;

namespace levelup.cli {
    public class Position {

        private readonly int _xCoordinates;
        private readonly int _yCoordinates;
        private readonly Point _coordinates;

        public int XCoordinates => _xCoordinates;
        public int YCoordinates => _yCoordinates;
        public Point Coordinates => _coordinates;
        

        public Position(){

        }

        public Position(int xCoordinates, int yCoordinates){
            _xCoordinates = xCoordinates;
            _yCoordinates = yCoordinates;
        }



        

    }
}