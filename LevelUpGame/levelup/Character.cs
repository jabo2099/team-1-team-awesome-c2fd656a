using levelup.cli;
namespace levelup;
public class Character
{
    static string DEFAULT_CHARACTER_NAME = "TEAM AWESOME";
    private string _name;
    private GameMap _map;
    private Position _position;
    private int _moveCount = 0; 

    public Character(){
        _name = DEFAULT_CHARACTER_NAME;
    }

    public Character(string name){
        
        _name = name;
    }

    public string GetName(){
        return _name;
    }

    public void EnterMap(GameMap map){
        SetMap(map);
        SetPosition(_map.GetStartingPosition());
    }

    public void SetMap(GameMap map){
        this._map = map;
    }
    
    public GameMap GetMap(){
        return this._map;
    }

    public void SetPosition(Position position){
        this._position = new Position(position.XCoordinates,position.YCoordinates);
    }
    public Position GetPosition(){
        return this._position;
    }

    public void Move(GameController.DIRECTION direction){
        SetPosition(this._map.calculatePosition(this._position, direction));
        this._moveCount++;
    }

    public int getMoveCount(){
        return this._moveCount;
    } 
    
}