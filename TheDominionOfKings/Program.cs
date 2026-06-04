Console.Write("How many provinces do you have: ");
string provinceInput = Console.ReadLine()!;

Console.Write("How man duchies do you have: ");
string duchiesInput = Console.ReadLine()!;

Console.Write("How man estates do you have: ");
string estateInput = Console.ReadLine()!;

int provinceAmount = int.Parse(provinceInput);
int duchiesAmount = int.Parse(duchiesInput);
int estateAmount = int.Parse(estateInput);

int estateTotal = estateAmount * 1;
int duchiesTotal = duchiesAmount * 3;
int provinceTotal = provinceAmount * 6;

Console.WriteLine("The total points is: " + (estateTotal + duchiesTotal + provinceTotal));