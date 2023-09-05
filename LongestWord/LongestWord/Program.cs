Console.WriteLine("=============================================" +
    "\nWelcome To The Longest Word Figure-Outer 9000" +
    "\n=============================================" +
    "\n" +
    "\nEnter a sentence, and I will tell you what the longest word within that sentence is!" +
    "\n(Top tip! punctuation doesn't count! but numbers do!)\n");

string? sen = string.Empty;
while (string.IsNullOrEmpty(sen))
{
    sen = Console.ReadLine();
    if (string.IsNullOrEmpty(sen))
    {
        Console.WriteLine("Please enter a valid string");
    }
    else
    {
        Console.WriteLine("\nThe longest word within that sentence is:\n" +
            LongestWord(sen));
    }
}

string LongestWord(string sen)
{
    char[] seperate = { ' ', ',', '.', '!', '?', '"', '£', '$', '%', '*', '-', ':', ';', '#', '@',
        '_', '(', ')', '~', '^', '<', '>', '/', '=', '+', '|', '[', ']', '{', '}', '&', '`', '¬' };
    string[] ListOfIndividualWords = sen.Split(seperate);
    string currentLongestWord = "";
    foreach (string word in ListOfIndividualWords)
    {
        if (word != null && word.Length > currentLongestWord.Length)
        {
            currentLongestWord = word;
        }
    }
    return currentLongestWord;
}