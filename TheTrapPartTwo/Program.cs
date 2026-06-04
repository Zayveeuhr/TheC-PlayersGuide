Console.Write("Give me the width of the pebble: ");
int pebbleWidth = int.Parse(Console.ReadLine()!);

Console.Write("Give me the length of the pebble: ");
int pebblelength = int.Parse(Console.ReadLine()!);

Console.Write("Give me the height of the pebble: ");
int pebbleHeight = int.Parse(Console.ReadLine()!);


if (pebbleHeight == pebblelength && pebblelength == pebbleWidth)
{
    Console.WriteLine("A");
}
else if (pebbleWidth > 10 || pebblelength > 10 || pebbleHeight > 10)
{
    Console.WriteLine("B");
}
else
{
    Console.WriteLine("C");
}
