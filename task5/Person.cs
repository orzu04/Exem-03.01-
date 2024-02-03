namespace task5;

public  class Person
{
    string _name;
    string _address;

    public Person (string name ,string address)
    {
        _name = name;
        _address = address;

    }
    public  void setAddress(string address)
    {
        _address = address;
    }

    public string getName()
    {
        return _name;
    }

       public string getAddress()
    {
        return _address;
    }

    public virtual void ToString()
    {
        System.Console.WriteLine($"Name: {_name}  Address: {_address}");
    }

}
