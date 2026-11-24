Console.WriteLine(MergeAlternately("abcdefgh", "pqrs"));

// word1: string, word2: string -> string
static string MergeAlternately(string word1, string word2)
{
    string mergedWord = "";

    int minLength = Math.Min(word1.Length, word2.Length);

    int i = 0;
    while (i < minLength)
    {
        mergedWord += word1[i];
        mergedWord += word2[i];
        i += 1;
    }

    string remaining = word1.Length > word2.Length ? word1[minLength..] : word2[minLength..];

    mergedWord += remaining;

    return mergedWord;
}
