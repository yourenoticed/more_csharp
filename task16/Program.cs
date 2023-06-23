int temp1;
int temp2;
Console.Write("Enter the first variable: ");
int variable1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second variable: ");
int variable2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third variable: ");
int variable3 = Convert.ToInt32(Console.ReadLine());

temp1 = variable2;
variable2 = variable3;
temp2 = variable1;
variable1 = temp1;
variable3 = temp2;

Console.WriteLine($"Variable1 is now {variable1}; variable2 is {variable2}; variable3 is {variable3}");

temp1 = variable2;
variable2 = variable1;
temp2 = variable3;
variable3 = temp1;
variable1 = temp2;

Console.WriteLine($"Variable1 is now {variable1}; variable2 is {variable2}; variable3 is {variable3}");