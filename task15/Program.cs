int temp;
Console.Write("Enter the first variable: ");
int variable1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second variable: ");
int variable2 = Convert.ToInt32(Console.ReadLine());

temp = variable1;
variable1 = variable2;
variable2 = temp;

Console.WriteLine($"Variable1 is now {variable1}; variable2 is {variable2}");