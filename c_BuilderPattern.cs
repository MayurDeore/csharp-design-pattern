//Builder
abstract class VehicleBuilder
{
    public abstract void BuildFrame();
    public abstract void BuildInterior();
    public abstract Vehicle ViewResult();
}

//Prdouct
class Vehicle
{
    private List<string> _parts = new List<string>();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public void Drive()
    {
        Console.WriteLine("\nVehicle Parts:");
        foreach (string part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}



//ConcreteBuilder
class CarBuilder: VehicleBuilder
{
    private Vehicle _product = new Vehicle();

    public override void BuildFrame()
    {
        _product.Add("Small frame");
    }

    public override void BuildInterior()
    {
        _product.Add("Leather interior");
    }
}

class TruckBuilder : VehicleBuilder
{
    private Vehicle _product = new Vehicle();

    public override void BuildFrame()
    {
        _product.Add("Heavy-duty frame");
    }

    public override void BuildInterior()
    {
        _product.Add("Fabric interior");
    }
}

//Director
class Factory
{
    public void Construct(VehicleBuilder builder)
    {
        builder.BuildFrame();
        builder.BuildInterior();
    }
}



//Usage

public class Program
{
    public static void Main()
    {
        //Create director and builders
        Factory factory = new Factory();
        VehicleBuilder carBuilder = new CarBuilder();
        VehicleBuilder truckBuilder = new TruckBuilder();

        //Construct two products
        factory.Construct(carBuilder);
        Vehicle car = carBuilder.ViewResult();
        car.Drive();

        factory.Construct(truckBuilder);
        Vehicle truck = truckBuilder.ViewResult();
        truck.Drive();
    }
}
