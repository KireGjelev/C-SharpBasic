
int[] numbers = { 2, 4, 7, 8, 11, 12 };
int sum = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}

Console.WriteLine("The sum of the even numbers is: " + sum);