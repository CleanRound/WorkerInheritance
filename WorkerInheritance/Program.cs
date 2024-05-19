public abstract class Worker
{
    public abstract void Print();
}

public class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("President: Responsible for overseeing the entire organization.");
    }
}

public class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Security: Ensures the safety and security of the company's premises and employees.");
    }
}

public class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Manager: Manages teams and projects to ensure company goals are met.");
    }
}

public class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Engineer: Designs, develops, and maintains systems and products.");
    }
}

class Program
{
    static void Main()
    {
        Worker president = new President();
        Worker security = new Security();
        Worker manager = new Manager();
        Worker engineer = new Engineer();

        president.Print();
        security.Print();
        manager.Print();
        engineer.Print();
    }
}
