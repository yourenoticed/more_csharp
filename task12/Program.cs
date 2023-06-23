Console.Write("Enter second vehicle speed: ");
double v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter first vehicle speed: ");
double v2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the distance between two cars: ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The time these two vehicles meet on distance {distance} is {distance / (v1 + v2)}");