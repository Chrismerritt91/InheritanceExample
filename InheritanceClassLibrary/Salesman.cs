public class Salesman : Employee
{

    //field
    private string _region;

    //constructor of child class

    public Salesman(int empId, string empName, string location, string region): base(empId,empName,location)
    {
        this._region = region;
    }

    //abstract method

    public override string GetHealthInsuranceAmount()
    {
        return "Additional Health Insurance Premium Amount is: " + 500;
    }

    //property

    public string Region { get { return _region; } set { _region = value; } }

    //method

    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }



}


