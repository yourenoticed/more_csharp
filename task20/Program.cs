Console.Write("Enter a 2-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9 && number < 100)
{
    int dozens = number / 10;
    int units = number % 10;
    Console.WriteLine($"Amount of dozens: {dozens}; amount of units: {units}");
    Console.WriteLine($"Sum of its digits: {dozens + units}; their product: {dozens * units}");
}
else Console.WriteLine("You were asked for a two-digit number");

