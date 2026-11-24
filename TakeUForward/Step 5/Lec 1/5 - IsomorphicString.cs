Console.WriteLine(IsIsomorphic("badc", "baba"));

// :type s: str
// :type t: str
// :rtype: bool
static bool IsIsomorphic(string s, string t)
{
    var hashmapST = new Dictionary<char, char>();
    var hashmapTS = new Dictionary<char, char>();

    // zip(s, t) -> iterate up to the shorter length
    for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
    {
        char c1 = s[i], c2 = t[i];
        if (
            (hashmapST.ContainsKey(c1) && hashmapST[c1] != c2) ||
            (hashmapTS.ContainsKey(c2) && hashmapTS[c2] != c1)
            )
            return false;

        hashmapST[c1] = c2;
        hashmapTS[c2] = c1;
    }

    return true;
}
