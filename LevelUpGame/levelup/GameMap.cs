using levelup.cli;
using System.Drawing;

namespace levelup
{
    public class GameMap {
        private int numPositions= MAX_X * MAX_Y;
        private Position [,] _positions;
        const int MAX_X = 10;
        const int MAX_Y = 10;

        private Position _startingPosition;
        
        public GameMap(){
            _startingPosition = new Position();
            _positions = new Position[MAX_X,MAX_Y];
        }

        public GameMap(Position startingPos, int maxX = MAX_X, int maxY = MAX_Y){       
            _startingPosition = new Position(startingPos.Coordinates.X, startingPos.Coordinates.Y);
            _positions = new Position[maxX,maxY];
        }

        private bool isPositionValid (Point positionCoordinates) {
            bool result = false;

            if (positionCoordinates.X < MAX_X && positionCoordinates.X >= 0 
                && positionCoordinates.Y < MAX_Y && positionCoordinates.Y >= 0) 
                {
                    result = true;
                }
            return result;
        }
    
        public Position GetStartingPosition(){
            return _startingPosition;
        }

        public Position[,] GetPositions(){
            return _positions;
;
        }
       
       public Position CalculatePosition (Position currentPosition, GameController.DIRECTION direction) {
            var currPoint = currentPosition.Coordinates;
            var result = currentPosition;

            switch(direction) 
            {
            case GameController.DIRECTION.NORTH:
                result = new Position(currPoint.X, currPoint.Y + 1); 
                break;
            case GameController.DIRECTION.SOUTH:
                result = new Position(currPoint.X, currPoint.Y - 1);
                break;
                case GameController.DIRECTION.EAST:
                result = new Position(currPoint.X + 1, currPoint.Y);
                break; 
                case GameController.DIRECTION.WEST:
                result = new Position(currPoint.X - 1, currPoint.Y);
                break;
            default:
                // code block
                break;
            }

            if (isPositionValid(result.Coordinates)) {
                return result;
            }else{
                return currentPosition;
            }
       }

       public int GetTotalPositions () {
         return GetPositions().GetLength(0) * GetPositions().GetLength(1);
       }
    }
}