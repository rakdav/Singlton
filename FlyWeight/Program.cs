using System.Collections;

void AddSpecialistDatabase(FlyweightFactory ff,
    string company, string position,string name,string password)
{
    Flyweight flyweight = ff.GetFlyweight(new Shared(company, position));
    flyweight.Process(new Unique(name,password));
}
FlyweightFactory fwFactory = new FlyweightFactory(new List<Shared>()
{
    new Shared("Microsoft","manager"),
    new Shared("Google","manager"),
    new Shared("Google","developer"),
    new Shared("Apple","developer")
});
fwFactory.ListFlyweights();
AddSpecialistDatabase(fwFactory, "Google", "developer", "Petr", "123344");
AddSpecialistDatabase(fwFactory, "KillMe", "developer", "Pepe", "98767");
fwFactory.ListFlyweights();
struct Shared
{
    private string company;
    private string position;
    public Shared(string _company,string _position)
    {
        company = _company;
        position = _position;
    }
    public string Company { get => company; }
    public string Position { get => position; }
}
struct Unique
{
    private string name;
    private string password;

    public Unique(string _name, string _password)
    {
        this.name = _name;
        this.password = _password;
    }
    public string Name { get => name; }
    public string Password { get => password; }
}

class Flyweight
{
    private Shared shared;
    public Flyweight(Shared _shared)
    {
        this.shared = _shared;
    }
    public void Process(Unique unique)
    {
        Console.WriteLine(shared.Company+" "+shared.Position+
            " "+unique.Name+" "+unique.Password);
    }
    public string GetData() => shared.Company + " " + shared.Position;
}

class FlyweightFactory
{
    private Hashtable flyweight;
    private string GetKey(Shared shared) => shared.Company + " " + shared.Position;

    public FlyweightFactory(List<Shared> shareds)
    {
        flyweight = new Hashtable();
        foreach (Shared item in shareds)
        {
            flyweight.Add(GetKey(item), new Flyweight(item));
        }
    }
    public Flyweight GetFlyweight(Shared shared)
    {
        string key = GetKey(shared);
        if (!flyweight.Contains(key))
        {
            Console.WriteLine("not found "+key);
            flyweight.Add(key,new Flyweight(shared));
        }
        else
        {
            Console.WriteLine("found:"+key);
        }
        return (Flyweight)flyweight[key]!;
    }
    public void ListFlyweights()
    {
        int count = flyweight.Count;
        Console.WriteLine("Fliweight factory:"+count);
        foreach (Flyweight item in flyweight.Values)
        {
            Console.WriteLine(item.GetData());
        }
    }
}
