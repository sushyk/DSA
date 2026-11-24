#pragma warning disable CS8321 // local function declared but never used (no driver calls in the Python original)
// (The Python original has no driver calls, so this file prints nothing.)

// s: string, t: string -> bool
static bool IsSubsequence(string s, string t)
{
    if (s == "" && t.Length >= 0)
    {
        return true;
    }
    else if (s.Length > 0 && t == "")
    {
        return false;
    }
    else
    {
        int i = 0, j = 0;

        while (i < s.Length && j < t.Length)
        {
            if (t[j] == s[i])
            {
                i += 1;
            }
            j += 1;
        }

        return i == s.Length;
    }
}
