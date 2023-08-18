using levelup.cli;

namespace levelup
{
    public class GameMap {
        public int numPositions=100;
        //private Position [,] positions; //TODO
        const int MAX_X = 10;
        const int MAX_Y = 10;

        private Position startingPosition;
        
        public GameMap(){
            startingPosition = new Position();
        }

        public GameMap(Position startingPos){
            startingPosition = new Position(startingPos.XCoordinates, startingPos.YCoordinates);
        }

        private bool IsPositionValid (Position positionCoordinates) {
            bool result = false;

            if (positionCoordinates.XCoordinates < MAX_X && positionCoordinates.XCoordinates >= 0 
                && positionCoordinates.YCoordinates < MAX_Y && positionCoordinates.YCoordinates >= 0) 
                {
                    result = true;
                }
            return result;
        }

        public Position GetStartingPosition(){
            return startingPosition;
        }

        public Position[][] GetPositions(){
            //TODO
            //return new Position[2,2];
            return null;
        }
       
       public Position CalculatePosition (Position currentPosition, GameController.DIRECTION direction) {
            var result = currentPosition;

            switch(direction) 
            {
                case GameController.DIRECTION.NORTH:
                    result = new Position(currentPosition.XCoordinates, currentPosition.YCoordinates + 1); 
                    break;
                case GameController.DIRECTION.SOUTH:
                    result = new Position(currentPosition.XCoordinates, currentPosition.YCoordinates - 1);
                    break;
                case GameController.DIRECTION.EAST:
                    result = new Position(currentPosition.XCoordinates + 1, currentPosition.YCoordinates);
                    break; 
                case GameController.DIRECTION.WEST:
                    result = new Position(currentPosition.XCoordinates - 1, currentPosition.YCoordinates);
                    break;
                default:
                    // code block
                    break;
            }

            if (IsPositionValid(result)) {
                return result;
            }else{
                return currentPosition;
            }
       }

       public int GetTotalPositions () {
         return MAX_X*MAX_Y;
       }
    }
}