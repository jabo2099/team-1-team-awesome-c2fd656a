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
        Map = map;
        var currentPosition = GetPosition();
    }

}