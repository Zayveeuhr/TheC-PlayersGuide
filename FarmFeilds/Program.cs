Console.Write("What is the length of the farm: ");
string lengthInput = Console.ReadLine()!;

int length = int.Parse(lengthInput);

Console.Write("What is the height of the farm: ");
string heightInput = Console.ReadLine()!;

int height = int.Parse(heightInput);

int area = length * height;

Console.WriteLine("The area of the farm is " + area);