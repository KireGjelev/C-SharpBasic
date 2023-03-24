
Console.WriteLine("Enter your birth year (month-day-year)");
string input = Console.ReadLine();
DateTime date;

bool success = DateTime.TryParse(input, out date);
if (success)
{
    string output = AgeCalculator(date);
    Console.WriteLine(output);
}
else
{
    Console.WriteLine("Invalid input!");
}


string AgeCalculator(DateTime dateOfBirth)
{
    int age = DateTime.Today.Year - dateOfBirth.Year;
    if (dateOfBirth > DateTime.Today)
    {
        return "Invalid input! You can't be born in the future.";
    }

    if (DateTime.Today < dateOfBirth.AddYears(age)) age--;
    return $"Based on your input, you were born on {dateOfBirth:d} and are currently {age} years old.";
}