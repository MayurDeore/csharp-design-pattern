public class Subject
{
    public virtual void Print()
    {
        Console.WriteLine("this is a print");
    }
}

public class SubjectProxy : Subject
{
    public override void Print()
    {
        Console.Write("Before calling base.Print()");
        base.Print();
        Console.Write("After calling base.Print()");
    }
}


//usage

var subject=new Subject();
subject.print(); // output: this is print

var sProxy=new SubjectProxy();
sProxy.print(); 

//output: 
//Before calling base.Print()
//this is print
//After calling base.Print()
