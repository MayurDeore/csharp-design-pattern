public class FacadeApp
{
    public bool IsSystemHealthy()
    {
        return IsDatabaseAHealthy() 
            && IsDatabaseBHealthy() 
            && IsServiceAHealthy() 
            && IsServiceBHealthy();
    }

    private bool IsDatabaseAHealthy()
    {
        //perform checks
        return true;
    }

    private bool IsDatabaseBHealthy()
    {
        //perform checks
        return true;
    }

    private bool IsServiceAHealthy()
    {
        //perform checks
        return true;
    }

    private bool IsServiceBHealthy()
    {
        //perform checks
        return true;
    }
}

public static void Main(string[] args)
{
    var facade = new FacadeApp();
    Console.WriteLine($"Is Facade App Healthy?: {facade.IsSystemHealthy()}");
}
