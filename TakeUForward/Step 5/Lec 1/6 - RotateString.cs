Console.WriteLine(RotateString("abc", "cab"));

// :type s: str
// :type goal: str
// :rtype: bool
static bool RotateString(string s, string goal)
{
    if (s == goal)
        return true;

    if (s.Length != goal.Length)
        return false;

    for (int i = 0; i < s.Length; i++)
    {
        string rotate = s[i..] + s[..i];
        if (rotate == goal)
            return true;
    }

    return false;
}
