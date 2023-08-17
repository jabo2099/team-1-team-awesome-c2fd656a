using Sharprompt;
using System.Collections;
namespace levelup.cli;
public class Character
{
    static string DEFAULT_CHARACTER_NAME = "TEAM AWESOME";
    private string Name;
    public Character(){
        Name = DEFAULT_CHARACTER_NAME;
    }

    public Character(string name){
        Name = name;
    }

    public string GetName(){
        return Name;
    }
}