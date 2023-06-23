Console.Write("Enter number a: ");
int number_a = Convert.ToInt32(Console.ReadLine());

double x = 12 * Math.Pow(number_a, 2) + 7 * number_a + 12;
double y = 7 * Math.Pow(x, 2) + 3 * x + 6;

Console.WriteLine($"When a is equal to {number_a}, x = {x}; y = {y}");
