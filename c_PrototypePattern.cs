//Prototype
abstract class Sheep
{
    private string _name;

    public Sheep(string name)
    {
        this._name = name;
    }

    public string Name
    {
        get { return _name; }
    }
    public abstract Sheep Clone();
}


//ConcretePrototype
class BlackSheep : Sheep
{
    public BlackSheep(string name) : base(name) { }

    public override Sheep Clone()
    {
        return (Sheep)this.MemberwiseClone();
    }
}


//


public class Program
{
    public static void Main()
    {
        //Create a concrete prototype instance to clone
        BlackSheep sheep = new Sheep("Barry");

        //clone concrete prototype
        BlackSheep sheep2 = (BlackSheep)sheep.Clone();

        Console.WriteLine("Cloned sheep likes being called {0}", sheep2.Name);
    }
}
