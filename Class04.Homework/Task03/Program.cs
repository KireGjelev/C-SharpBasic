
int SumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int number = 12345;
int sum = SumOfDigits(number);
Console.WriteLine($"The sum of digits in {number} is {sum}");

string LargestWord(string sentence)
{
    string[] words = sentence.Split(' ');
    string largestWord = "";
    foreach (string word in words)
    {
        if (word.Length > largestWord.Length)
        {
            largestWord = word;
        }
    }
    return largestWord;
}

string sentence = "We are having a lot of fun on vacation";
string largestWord = LargestWord(sentence);
Console.WriteLine($"The largest word in '{sentence}' is '{largestWord}'");