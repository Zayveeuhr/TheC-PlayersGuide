Console.Write("Give me your width: ");
string widthInput = Console.ReadLine()!;

Console.Write("Give me your length: ");
string lengthInput = Console.ReadLine()!;

int width = int.Parse(widthInput);
int length = int.Parse(lengthInput);

int totalOne = (width + length) / 2 * width;
int totaltwo = (length + width) / 2 * length;

Console.WriteLine($"Total for the first equation is {totalOne} the total for the second is {totaltwo}");