#pragma warning disable CS8321 // functions are defined but not called (same as the Python)
// (The Python file defines the function but never calls it, so nothing is printed.)

// :type s: str
// :rtype: str
static string ReverseWords(string s)
{
    // Python s.split(): split on any whitespace, drop empty entries
    string[] sArray = s.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);

    int l = 0, r = sArray.Length - 1;

    while (l <= r)
    {
        (sArray[l], sArray[r]) = (sArray[r], sArray[l]);
        l += 1;
        r -= 1;
    }

    return string.Join(" ", sArray);
}
