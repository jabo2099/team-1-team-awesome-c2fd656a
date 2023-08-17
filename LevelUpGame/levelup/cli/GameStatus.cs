namespace levelup.cli;

public class GameStatus {

    public String CharacterName{get;set;}
    public Position? Position{get;set;}
    public int MoveCount{get; set;}

    public GameStatus(){

    }

    public GameStatus(string characterName, Position position, int moveCount) {
        CharacterName = characterName;
        Position = position;
        MoveCount = moveCount;
    }

    public override string ToString() {
        return String.Format($"Character Name: {CharacterName} , X-Coordinate: {Position.XCoordinates}, Y-Coordinate: {Position.YCoordinates}, Move Count: {MoveCount}");
    }
}