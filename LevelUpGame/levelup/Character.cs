namespace levelup;
public class Character
{
    static string DEFAULT_CHARACTER_NAME = "TEAM AWESOME";
    private string Name;
    private GameMap Map;
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
    }

    public void SetMap(GameMap map){
        this.Map = map;
    }
    
    public GameMap GetMap(){
        return this.Map;
    }

}