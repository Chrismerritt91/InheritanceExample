﻿public class Program
{

    static void Main()
    {

        //create object of employee
        Employee emp1 = new Employee();
        emp1.EmpID = 101;
        emp1.EmpName = "Scott";
        emp1.Location = "Hyderabad";
        Console.WriteLine("Object of Parent class (Employee):");
        Console.WriteLine(emp1.EmpID);
        Console.WriteLine(emp1.EmpName);
        Console.WriteLine(emp1.Location);
        Console.WriteLine();


        //create object of manager
        Manager mgr1 = new Manager();
        mgr1.EmpID = 102;
        mgr1.EmpName = "Allen";
        mgr1.Location = "New York";
        mgr1.Department = "Accounting";
        Console.WriteLine("Object of Child class (Manager):");
        Console.WriteLine(mgr1.EmpID);
        Console.WriteLine(mgr1.EmpName);
        Console.WriteLine(mgr1.Location);
        Console.WriteLine(mgr1.Department);
        Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        Console.WriteLine();

        //create object of salesman
        Salesman salesman1 = new Salesman();
        salesman1.EmpID = 101;
        salesman1.EmpName = "John";
        salesman1.Location = "Washington";
        salesman1.Region = "East";
        Console.WriteLine("Object of Child class (Salesman):");
        Console.WriteLine(salesman1.EmpID);
        Console.WriteLine(salesman1.EmpName);
        Console.WriteLine(salesman1.Location);
        Console.WriteLine(salesman1.Region);
        Console.WriteLine(salesman1.GetSalesOfTheCurrentMonth());
        Console.WriteLine();

        Console.ReadKey();

    }

}