public class Program
{

    static void Main()
    {

        //create object of employee
        Employee emp1 = new Employee(101, "Scott", "Hyderabad");
        Console.WriteLine("Object of Parent class (Employee):");
        Console.WriteLine(emp1.EmpID);
        Console.WriteLine(emp1.EmpName);
        Console.WriteLine(emp1.Location);
        Console.WriteLine(emp1.GetHealthInsuranceAmount());
        Console.WriteLine();


        //create object of manager
        Manager mgr1 = new Manager(102, "Allen", "New York", "Accounting");
        Console.WriteLine("Object of Child class (Manager):");
        Console.WriteLine(mgr1.EmpID);
        Console.WriteLine(mgr1.EmpName);
        Console.WriteLine(mgr1.Location);
        Console.WriteLine(mgr1.Department);
        Console.WriteLine(mgr1.GetTotalSalesOfTheYear());
        Console.WriteLine(mgr1.GetFullDepartmentName());
        Console.WriteLine(mgr1.GetHealthInsuranceAmount());
        Console.WriteLine();

        //create object of salesman
        Salesman salesman1 = new Salesman(103,"John","Washington","East");
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