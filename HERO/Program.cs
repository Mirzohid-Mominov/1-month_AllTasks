

using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.Serialization;

var game = new OptimizedGame();
game.Display();

public class HERO
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public HERO(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    public override string ToString()
    {
        return $"Name : {Name}\n ID {Id}";
    }
}

public class GameEngine
{
    public List<HERO> heros = new List<HERO>();
    
    public GameEngine()
    {
        heros.Add(new HERO("AdmeraL007"));
        heros.Add(new HERO("Cumersi"));
        heros.Add(new HERO("LinShan"));

    }

    public void Display()
    {
        foreach (var hero in heros)
        {
            Console.WriteLine(hero);
        }
    }
}


public class  OptimizedGame : GameEngine
{
    public OptimizedGame()
    {
        heros.Add(new HERO("SubZero"));
        heros.Add(new HERO("Scalpion"));
        heros.Add(new HERO("Shiva"));
    }
}


