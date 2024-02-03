

List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};


foreach (var numb in list)
{
    System.Console.Write(numb);
}


list.Sort();
foreach (var numb in list )
{
    System.Console.WriteLine(numb);
}

