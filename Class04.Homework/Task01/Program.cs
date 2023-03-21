
string[] arrayOfStrings;
{
    Console.Write("Enter a string: ");
    string input = Console.ReadLine();

    if (input.Length >= 5)
    {
        Console.WriteLine("The last 5 characters are: " + input.Substring(input.Length - 5));
    }
    else
    {
        Console.WriteLine("That string is too short!");
    }
}