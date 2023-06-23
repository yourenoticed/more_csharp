const int screen = 1000; // per unit
const int pc = 50000;
const int keyboard = 500;
const int mouse = 400;
Console.Write("Enter amount of computers you want to purchase: ");
int amount = Convert.ToInt32(Console.ReadLine());
int sum = screen + pc + keyboard + mouse;
Console.WriteLine($"Total sum for {amount} computers is {sum * amount}");
