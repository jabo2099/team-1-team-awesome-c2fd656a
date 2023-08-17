namespace levelup;
public class Character
{
    static string DEFAULT_CHARACTER_NAME = "TEAM AWESOME";
    private string Name;
    private GameMap Map;
    private Position Position;
    public Character(){
        Name = DEFAULT_CHARACTER_NAME;
    }

    public Character(string name){
        Name = name;
    }

    public string GetName(){
        return Name;
    }

    public void EnterMap(GameMap map){
        SetMap(map);
        SetPosition(Map.GetStartingPosition());
    }

    public void SetMap(GameMap map){
        this.Map = map;
    }
    
    public GameMap GetMap(){
        return this.Map;
    }

    public void SetPosition(Position position){
        this.Position = new Position(position.xCoordinate,position.yCoordinate);
    }

    
}