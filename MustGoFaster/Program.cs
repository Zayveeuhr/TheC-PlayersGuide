int iChannel = 0;

Console.Write("\nEnter the secret symbol: ");
string sSecretSymbol = Console.ReadLine()!;

int iChannelOut = sSecretSymbol switch
{
    "x" => iChannel = 2,
    "o" => iChannel = 3,
    "^" => iChannel = 1,
    "#" => iChannel = 4,
    _   => iChannel = 0
};

Console.WriteLine($"\nThe channel number you have choosen is {iChannel}\n");