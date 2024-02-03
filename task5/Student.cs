namespace task5;

public class Student:Person

{
   string _program;
   int _year;
   double _fee;
  
  public Student(string name,string address,string program, int year,double fee):base(name,address)
  {
     _program = program;
     _year = year;
     _fee = fee;
  }
  public void SetProfram(string program)
  {
    _program = program;
  }
  public void SetYear(int year)
  {
    _year = year;
  }
  public void SetFee(double fee)
  {
    _fee = fee;
  }
  

  public string getProgram()
  {
    return _program;

  }
 
 public int getYear()
  {
    return _year ;

  }

  
 public double getFee()
  {
    return _fee ;

  }
  public override  void ToString()
    {
        
        System.Console.WriteLine($"Progtam: {_program} Year: {_year} Fee: {_fee} ");
    }

 
}
