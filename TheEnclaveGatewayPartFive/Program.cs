Console.WriteLine("Enter some text below: ");
string someInput = Console.ReadLine()!.ToLower();

if (someInput.Length == 3)
{
    int secretNum = 0;
    string sercretWord = "";
    string secretWordTwo = string.Empty;
    string secrertWordThree = string.Empty;

    if (someInput[0].Equals('^') || someInput[0].Equals('#') || someInput[0].Equals('x') || someInput[0].Equals('o'))
    {
        if (someInput[0].Equals('#'))
        {
            sercretWord = "dah";
            secretNum += 4;
        }
        else if (someInput[0].Equals('o',))
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
    }
    else if (someInput[1].Equals('^') || someInput[1].Equals('#') || someInput[1].Equals('x') || someInput[1].Equals('o'))
    {
        if (someInput[0].Equals('#'))
        {
            secretWordTwo = "dah";
            secretNum += 4;
        }
        else if (someInput[0].Equals('o',))
        {
            secretWordTwo = "fus";
            secretNum += -3;
        }
        else if (someInput[0].Equals('^'))
        {
            secretWordTwo = "ro";
            secretNum += -2;
        }
        else if (someInput[0].Equals('x'))
        {
            secretWordTwo = "bex";
            secretNum += 1;
        }
    }
    else if (someInput[2].Equals('^') || someInput[2].Equals('#') || someInput[2].Equals('x') || someInput[2].Equals('o'))
    {
        if (someInput[0].Equals('#'))
        {
            secrertWordThree = "dah";
            secretNum += 4;
        }
        else if (someInput[0].Equals('o',))
        {
            secrertWordThree = "fus";
            secretNum += -3;
        }
        else if (someInput[0].Equals('^'))
        {
            secrertWordThree = "ro";
            secretNum += -2;
        }
        else if (someInput[0].Equals('x'))
        {
            sercretWord = "bex";
            secretNum += 1;
        }
    }

    Console.WriteLine("Secret password is: " + sercretWord + " and numeber is " + secretNum);
}
else
{
    Console.WriteLine("No valid input");
}