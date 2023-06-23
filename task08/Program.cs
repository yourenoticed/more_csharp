
Console.Write("Enter the country's area (in sqr kms): ");
double area = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the population: ");
double population = Convert.ToDouble(Console.ReadLine());

double pop_density = population / area;
Console.WriteLine($"Population density of the country is {pop_density}");
