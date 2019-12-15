//Product
abstract class Fish { }

//ConcreteProduct
class Salmon : Fish { }
class Tuna : Fish { }


//Creator
abstract class Fisherman
{
    public abstract Fish Catch();
}


//ConcreteCreator
class CatchSalmon : Fisherman
{
    public override Fish Catch()
    {
        return new Salmon();
    }
}


class CatchTuna : Fisherman
{
    public override Fish Catch()
    {
        return new Tuna();
    }
}



//Usage

public class Program
{
    public static void Main()
    {
        //An array of creators
        Fisherman[] fishermen = new Fisherman[2];

        fishermen[0] = new CatchSalmon();
        fishermen[1] = new CatchTuna();

        //Iterate over creators to create products
        foreach (Fisherman fisherman in fishermen)
        {
            Fish fish = fisherman.Catch();
            Console.WriteLine("Caught {0}", fish.GetType().Name);
        }
    }
}
