
string[] studentsG1 = { "Novak", "Roger", "Matteo ", "Serena", "Rafael" };
string[] studentsG2 = { "Ana", "Venus", "Stefanos", "Daniil", "Carlos" };

Console.Write("Enter student group (1 or 2): ");
int group = int.Parse(Console.ReadLine());

if (group == 1)
{
    Console.WriteLine("Students in group 1: ");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (group == 2)
{
    Console.WriteLine("Students in group 2: ");
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid group number!");
}