Console.Write("Enter your first number: ");
double firstNum = double.Parse(Console.ReadLine()!);

Console.Write("Enter your second number: ");
double secondNum = double.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(firstNum, 2) + Math.Pow(secondNum, 2));

Console.WriteLine("The distance from piont " + firstNum + " to " + secondNum + " is " + distance);