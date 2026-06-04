Console.WriteLine("Enter some text below: ");
string someInput = Console.ReadLine()!.ToLower();

if (someInput.Length == 3)
{
    int secretNum = 0;
    string sercretWord = "";

    if (someInput[0] == '#')
    {
        sercretWord = "dah";
        secretNum += 4;
    }
    else if (someInput[0].Equals('o'))
    {
        sercretWord = "fus";
        secretNum += -3;
    }
    else if (someInput[0].Equals('^'))
    {
        sercretWord = "ro";
        secretNum += -2;
    }
    else if (someInput[0].Equals('x'))
    {
        sercretWord = "bex";
        secretNum += 1;
    }

    Console.WriteLine("Secret password is: " + sercretWord + " and numeber is " + secretNum);
}
else
{
    Console.WriteLine("No valid input");
}