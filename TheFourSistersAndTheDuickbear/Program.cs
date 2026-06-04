Console.Write("Enter the number of eggs gathered today: ");
int eggsInput = int.Parse(Console.ReadLine()!);

Console.WriteLine("The sisters will get " + eggsInput / 3 + " each.");
Console.WriteLine("The duckbear will get " + eggsInput % 3 + ".");
