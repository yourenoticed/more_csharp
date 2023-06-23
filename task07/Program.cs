Console.WriteLine("Enter a cube's side: ");
int side = Convert.ToInt32(Console.ReadLine());
double volume = Math.Pow(side, 3);
double area = Math.Pow(side, 2);
Console.WriteLine($"Volume of cube with side {side} is {volume}; Area of a side is {area}");
