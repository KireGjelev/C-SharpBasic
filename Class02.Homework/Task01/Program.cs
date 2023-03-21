double firstNumber;
double secondNumber;
double result;
string operation;

Console.Write("Enter the First number: ");
firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Second number: ");
secondNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the Operation (+, -, *, /): ");
operation = Console.ReadLine();

switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        Console.WriteLine("The result is: " + result);
        break;

    case "-":
        result = firstNumber - secondNumber;
        Console.WriteLine("The result is: " + result);
        break;

    case "*":
        result = firstNumber * secondNumber;
        Console.WriteLine("The result is: " + result);
        break;

    case "/":
        if (secondNumber == 0)
        {
            Console.WriteLine("Error: Division by zero!");
        }
        else
        {
            result = firstNumber / secondNumber;
            Console.WriteLine("The result is: " + result);
        }
        break;

    default:
        Console.WriteLine("Error: Invalid operation!");
        break;
}
Console.ReadKey();