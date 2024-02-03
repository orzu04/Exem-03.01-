namespace task5;

public class Staff:Person
{


    string _school;

    double _pay;
    public Staff(string name , string address ,string school,double pay):base(name,address)
    {
        _school = school;
            _pay = pay;
    }

    public void setSchool(string school)
    {
        _school = school;
    }

  public void setPay(double pay)
    {
        _pay = pay;
    }


    public string getSchool()
    {
        return _school;
    }

    public double getPay()
    {
        return _pay;
    }


  public void GetStaff()
  {
System.Console.WriteLine($"{_school} {_pay}");
  }
    


}
