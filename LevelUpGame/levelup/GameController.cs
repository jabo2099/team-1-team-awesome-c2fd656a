using System.Drawing;

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "TEAM AWESOME";
        public Character _character;

        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Point currentPosition,
            int moveCount
            );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            //Set current position to a nonsense place until you figure out who should initialize
            status.currentPosition = new Point(0,0);
            //TODO: Write a failing unit test that will force you to set this to the right number
            status.moveCount = 0;
        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name)
        {
            if (name != null && !name.Equals(""))
            {
                this.status.characterName = name;
            }
            else
            {
                this.status.characterName = DEFAULT_CHARACTER_NAME;
            }
        }

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create positions and put the character on one
            // TODO: Should also update the game status?

            if(string.IsNullOrEmpty( this.status.characterName))
            {
                _character = new Character();
            }
            else
            {
                _character = new Character(this.status.characterName);
            }

            _character.EnterMap(new GameMap());

        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
            _character.Move(directionToMove);
            SetCharacterPosition(_character.GetPosition().Coordinates);
            SetCurrentMoveCount(_character.GetMoveCount());
        }

        public void SetCharacterPosition(Point coordinates)
        {
            status.currentPosition = new Point(coordinates.X, coordinates.Y);
        }

        public void SetCurrentMoveCount(int moveCount)
        {
            //TODO: IMPLEMENT THIS TO SET CURRENT MOVE COUNT -- exists to be testable
            status.moveCount = moveCount;
            _character.SetMoveCount(moveCount);

        }

        public int GetTotalPositions()
        {
            //TODO: IMPLEMENT THIS TO GET THE TOTAL POSITIONS FROM THE MAP -- exists to be testable
            return _character.GetMap().GetTotalPositions();
        }


    }
}