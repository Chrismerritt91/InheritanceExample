public class Manager : Employee
{

    //field
    private string _department;

    //constructor
    // calling parent class constructor to use child's constructor to initialize parent class's fields

    public Manager(int empId, string empName, string location, string department) : base(empId,empName,location)
    {
        this._department = department;

    }

    //property
    public string Department { get { return _department; } set { _department = value; } }

    //method
    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }

    public string GetFullDepartmentName()
    {
        return Department + " at " + base.Location;
    }

    //method overriding
    public sealed override string GetHealthInsuranceAmount()
    {
        Console.WriteLine(base.GetHealthInsuranceAmount());
        return "Additional Health Insurance Premium Amount is: " + 1000;
    }


    //child class
    public class BranchManager: Manager
    {
        //constructor of child class
        public BranchManager(int empId, string empName, string location, string department) : base(empId, empName, location, department)
        {
        }

        //method overriding of virtual methods// not allowed
        //public override string GetHealthInsuranceAmount()
        //{
        //}

    }

}
