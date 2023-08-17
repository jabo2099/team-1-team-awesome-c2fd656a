using System.Drawing;
using levelup.cli;

namespace levelup
{
    public class GameMap {
        public int numPositions=100;
        private Position [,] positions; //TODO

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

        public Position[][] GetPositions(){
            //TODO
            //return new Position[2,2];
            return null;
        }
       
       public Position calculatePosition (Position startingPosition, GameController.DIRECTION direction) {
            var result = startingPosition;

            switch(direction) 
            {
            case GameController.DIRECTION.NORTH:
                result = new Position(startingPosition.XCoordinates, startingPosition.YCoordinates + 1); 
                break;
            case GameController.DIRECTION.SOUTH:
                result = new Position(startingPosition.XCoordinates, startingPosition.YCoordinates - 1);
                break;
                case GameController.DIRECTION.EAST:
                result = new Position(startingPosition.XCoordinates + 1, startingPosition.YCoordinates);
                break; 
                case GameController.DIRECTION.WEST:
                result = new Position(startingPosition.XCoordinates - 1, startingPosition.YCoordinates);
                break;
            default:
                // code block
                break;
            }

            return result;
       }


    }
}