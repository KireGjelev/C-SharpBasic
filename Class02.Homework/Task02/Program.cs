
Console.Write("Enter the First number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter the Second number: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter the Third number: ");
int num3 = int.Parse(Console.ReadLine());

Console.Write("Enter the Fourth number: ");
int num4 = int.Parse(Console.ReadLine());

double average = (num1 + num2 + num3 + num4) / 4.0;

Console.WriteLine("The average of {0}, {1}, {2}, and {3} is: {4}", num1, num2, num3, num4, average);

Console.ReadKey();