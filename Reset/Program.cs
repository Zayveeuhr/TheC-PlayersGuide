int iChannel = 0;

Console.Write("\nEnter the secret symbol: ");
string sSecretSymbol = Console.ReadLine()!;

switch (sSecretSymbol)
{
    case "x":
        iChannel = 2;
        break;
    case "o":
        iChannel = 3;
        break;
    case "^":
        iChannel = 1;
        break;
    case "#":
        iChannel = 4;
        break;
    default:
        iChannel = 0;
        break;
}

Console.WriteLine($"\nThe channel number you have choosen is {iChannel}\n");