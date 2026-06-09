Console.Write("Type the 3 digit name: ");
string name = Console.ReadLine()!;

if (name.Length == 3)
{
    if (char.IsDigit(name[0]) && char.IsDigit(name[1]) && char.IsDigit(name[2]))
    {
        Console.WriteLine(name);
    }
    else
    {
        Console.WriteLine("Those were not digits.");
    }
}
else
{
    Console.WriteLine("Name is to long.");
}
