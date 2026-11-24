Console.WriteLine(ReverseWords(" hello world sushil  "));

// :type s: str
// :rtype: str
static string ReverseWords(string s)
{
    // Python s.split(): split on any whitespace, drop empty entries
    string[] wordsArray = s.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);

    int l = 0, r = wordsArray.Length - 1;

    while (l < r)
    {
        (wordsArray[l], wordsArray[r]) = (wordsArray[r], wordsArray[l]);
        l += 1;
        r -= 1;
    }

    return string.Join(" ", wordsArray);
}
