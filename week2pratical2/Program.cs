Main();
static void Main()
{
    Console.WriteLine("Enter a String:");
    string str = Console.ReadLine();

    int wordCount = 0;

    for (int letter = 0; letter < str.Length; letter++)
    {
        if (char.IsUpper(str[letter]))
        {
            wordCount++;

        }


    }
    Console.WriteLine($"This the string , {str}");
    Console.WriteLine("Number of words: " + wordCount);

}
