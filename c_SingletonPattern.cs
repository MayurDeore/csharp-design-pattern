//non-thread-safe

public class Singleton
{
    private static Singleton instance;
    private Singleton() {}

    public static Singleton Instance
    {
        get
        {
            if( instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}



//Static thread-safe
public sealed class Singleton
{
    private static readonly Singleton instance = new Singleton();
    private Singleton() {}

    public static Singleton Instance
    {
        get
        {
            return instance;
        }
    }
}


//multithread example
public sealed class Singleton
{
    private static volatile Singleton instance;
    private static object syncRoot = new Object();
    private Singleton() {}

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if(instance == null){
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}
