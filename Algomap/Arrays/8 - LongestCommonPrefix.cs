#pragma warning disable CS8321 // local function declared but never used (no driver calls in the Python original)
// (The Python original has no driver calls, so this file prints nothing.)

// strs: List[str] -> str
static string LongestCommonPrefix(string[] strs)
{
    int minLength = int.MaxValue; // float("inf")

    foreach (var s in strs)
    {
        if (s.Length < minLength)
        {
            minLength = s.Length;
        }
    }

    int i = 0;
    while (i < minLength)
    {
        foreach (var s in strs)
        {
            if (s[i] != strs[0][i])
            {
                return strs[0][..i];
            }
        }
        i += 1;
    }

    return strs[0][..i];
}
