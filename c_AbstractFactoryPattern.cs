//AbstractFactory 
abstract class DepartmentFactory
{
    public abstract Employee CreateEmployee();
    public abstract Manager CreateManager();
}


//ConcreteFactory
class SalesFactory: DepartmentFactory
{
    public override Employee CreateEmployee()
    {
        return new Salesman();
    }

    public override Manager CreateManager()
    {
        return new SalesManager();
    }
}

class MarketingFactory : DepartmentFactory
{
    public override Employee CreateEmployee()
    {
        return new MarketingAnalyst();
    }

    public override Manager CreateManager()
    {
        return new MarketingManager();
    }
}


//AbstractProduct
abstract class Employee { }

abstract class Manager
{
    public abstract void Interact(Employee employee);
}

//Product
class Salesman : Employee { }

class SalesManager : Manager
{
    public override void Interact(Employee employee)
    {
        Console.WriteLine(this.GetType().Name + " interacts with " + employee.GetType().Name);
    }
}


class MarketingAnalyst : Employee { }

class MarketingManager : Manager
{
    public override void Interact(Employee employee)
    {
        Console.WriteLine(this.GetType().Name + " interacts with " + employee.GetType().Name);
    }
}


//Client
class Department
{
    private Employee _employee;
    private Manager _manager;

    public Department(DepartmentFactory factory)
    {
        _employee = factory.CreateEmployee();
        _manager = factory.CreateManager();
    }

    public void Run()
    {
        _manager.Interact(_employee);
    }
}




//How to use

public class Program
{
    public static void Main()
    {
        //Abstract Factory for Sales Department
        DepartmentFactory SalesFactory = new SalesFactory();
        Department SalesTeam = new Department(SalesFactory);

        //Abstract Factory for Marketing Department
        DepartmentFactory MarketingFactory = new MarketingFactory();
        Department MarketingTeam = new Department(MarketingFactory);
    }
}
