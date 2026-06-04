Console.Write("Enter the radius of the circle: ");
int radiusInput = int.Parse(Console.ReadLine()!);

double area = Math.PI * Math.Pow((double)radiusInput, 2);

Console.WriteLine("The area of the circle is " + area);