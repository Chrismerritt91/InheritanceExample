public class Salesman : Employee
{

    //field
    private string _region;

    //constructor

    public Salesman(int empId, string empName, string location, string region): base(empId,empName,location)
    {
        this._region = region;
    }

    //property
    public string Region { get { return _region; } set { _region = value; } }

    //method
    public long GetSalesOfTheCurrentMonth()
    {
        return 1000;
    }



}


