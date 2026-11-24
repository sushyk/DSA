Console.WriteLine($"\"{LargestOddNumber("52")}\"");    // "5"
Console.WriteLine($"\"{LargestOddNumber("4206")}\"");  // ""
Console.WriteLine($"\"{LargestOddNumber("35427")}\""); // "35427"

// :type num: str
// :rtype: str
static string LargestOddNumber(string num)
{
    for (int i = num.Length - 1; i >= 0; i--)
    {
        // fixed: look for the rightmost ODD digit (Python checked for even)
        if ((num[i] - '0') % 2 == 1)
            return num[..(i + 1)];
    }

    return "";
}
