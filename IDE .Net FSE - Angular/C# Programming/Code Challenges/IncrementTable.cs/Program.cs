using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Employee{
    protected string name;
    protected double salary;

    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name}\nSalary: {salary}");
    }
}

public class Programmer : Employee,IIncrementtable
{
    protected string domain;

    public Programmer(string domain):base("",0)
    {
        this.domain = domain;
    }

    public Programmer(string name, double salary, string domain):base(name,salary)
    {
        this.domain = domain;
    }

    public double Increment()
    {
        double incrementAmount = salary*0.1;
        salary += incrementAmount;
        return salary;
    }
}

public class Manger : Employee,IIncrementable
{
    protected string teamId;

    public Manager(string teamId):base("",0)
    {
        this.teamId = teamId;
    }

    public Manager(string name, double salary, string teamId):base(name,salary)
    {
        this.teamId = teamId;
    }

    public double Increment()
    {
        double incrementAmount = salary*0.5;
        salary += incrementAmount;
        return salary;
    }
}

public interface IIncrementable
{
    double Increment();
}

public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the details of Manager");
        string mangerName = Console.ReadLine();
        double managerSalary = Console.ReadLine();
        string teamId = Console.ReadLine();

        Manager manager = new Manager(managerName, managerSalary, teamId);

        Console.WriteLine("Enter the details of Programmer");
        string programmerName = Console.ReadLine();
        double programmerSalary = Convert.ToDouble(Console.ReadLine());
        string domain = Console.ReadLine();

        Programmer programmer = new Programmer(programmerName, programmerSalary, domain);

        Console.Write("Name:");
        mangerName.Print();
        double mangerIncrementedSalary = manager.Increment();
        Console.WriteLine("Salary: "+managerIncrementedSalary);

        Console.Write("Name:");
        programmer.Print();
        double programmerIncrementedSalary = programmer.Increment();
        Console.WriteLine("Salary: "+programmerIncrementSalary);
    }
}