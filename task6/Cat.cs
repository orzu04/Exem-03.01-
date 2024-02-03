namespace task6;

public class Cat :Animal
{


     string _name;

    public Cat (string name)
    {
        _name = name;

    }
    public override string GetName()
    {
        return $"{_name} ";
    }

    public override void Greets (){
        System.Console.WriteLine($"{_name}");
          System.Console.WriteLine($"Meow");
    }

}
