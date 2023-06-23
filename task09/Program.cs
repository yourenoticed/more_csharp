const int sweets = 400; //za kg
const int biscuits = 500;
const int apples = 250;
Console.Write("Enter weight of bought sweets: ");
double sweets_weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter weight of bought biscuit: ");
double buscuits_weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter weight of apples sweets: ");
double apples_weight = Convert.ToDouble(Console.ReadLine());

double sum = sweets * sweets_weight + biscuits * buscuits_weight + apples * apples_weight;
Console.WriteLine($"Total sum is {sum}");


