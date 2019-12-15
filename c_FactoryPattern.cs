public enum Shipper
{
    UPS = 1,
    FedEx = 2
}

public interface IShip
{
    void Ship();
}


public class ShipperUPS : IShip
{
    public void Ship()
    {
        //-- code logic to implement shipping method for UPS
        MessageBox.Show("UPS ship start");
    }
}

public class ShipperFedEx : IShip
{
    public void Ship()
    {
        //-- code logic to implement shipping method for FedEx
        MessageBox.Show("FedEx ship start");
    }
}

public class ShipperFactory
{
    public static IShip CreateInstance(Shipper enumModuleName)
    {
        IShip objActivity = null;

        switch (enumModuleName)
        {
            case Shipper.UPS:
                objActivity = new ShipperUPS();
                break;
            case Shipper.FedEx:
                objActivity = new ShipperFexEx();
                break; 
            
            default:
                break;
        }
        return objActivity;
    }
}
