Console.Write("Enter temperature in Celcius: ");
double celcius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = celcius * 1.8 + 32;
double kelvin = celcius + 273.15;

Console.WriteLine($"{celcius} degrees celcius is {fahrenheit}F; {kelvin}K");