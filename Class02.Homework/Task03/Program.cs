
int firstNumber;
int secondNumber;
int temp;

Console.WriteLine("Enter the first number: ");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Before: ");
Console.WriteLine("First number: " + firstNumber);
Console.WriteLine("Second number: " + secondNumber);

temp = firstNumber;
firstNumber = secondNumber;
secondNumber = temp;

Console.WriteLine("After:");
Console.WriteLine("First number: " + firstNumber);
Console.WriteLine("Second number: " + secondNumber);

Console.ReadLine();
