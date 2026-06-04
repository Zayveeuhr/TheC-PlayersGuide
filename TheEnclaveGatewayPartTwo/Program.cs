Console.WriteLine("Enter some text below: ");
string someInput = Console.ReadLine()!;

if (someInput.Length == 3) 
{
    int secretNum = 0;

    if (someInput[0] == '#')
    {
        secretNum += 4;
    }

    Console.WriteLine("Secret password is: " + someInput + " and numeber is " + secretNum);
}
else
{
    Console.WriteLine("No valid input");
}
