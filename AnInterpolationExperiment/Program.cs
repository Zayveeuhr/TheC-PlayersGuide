using System.ComponentModel;

Console.Write("Give me the first number: ");
int iFirstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Enter second number: ");
int iSecondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine($"\nThe number {iFirstNumber}+{iSecondNumber}={iFirstNumber + iSecondNumber}\n");