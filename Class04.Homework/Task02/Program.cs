
string[] arrayOfStrings;
{
    Console.Write("Enter a sentence: ");
    string input = Console.ReadLine();

    string[] words = input.Split(' ');

    Console.WriteLine("Words in the sentence:");

    foreach (string word in words)
    {
        Console.WriteLine(word);
    }
}