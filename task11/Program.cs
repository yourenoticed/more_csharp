Console.Write("Enter girl's age: ");
double girl = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter man's age: ");
double man = Convert.ToInt32(Console.ReadLine());

double avg = (girl + man) / 2;

double difference = Math.Abs(girl - avg);


Console.WriteLine($"Average age is {avg}");
Console.WriteLine($"The difference between the average and the age of each kid is {difference}");
