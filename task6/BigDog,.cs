namespace task6;



public class BigDog :Animal
{


     string _name;

    public BigDog (string name)
    {
        _name = name;

    }
    public override string GetName()
    {
        return $"{_name} ";
    }

    public override void Greets (){
        System.Console.WriteLine($"{_name}");
          System.Console.WriteLine($"Woow");
    }

}