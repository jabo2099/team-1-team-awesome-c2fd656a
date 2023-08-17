namespace levelup.cli;

public class GameStatus {

    public String CharacterName{get;set;}
    public Position Position{get;set;}

    public GameStatus(){

    }

    public GameStatus(string characterName, Position position) {
        CharacterName = characterName;
        Position = position;
    }
}