#pragma warning disable CS8321 // functions are defined but not called (same as the Python)
// (The Python file defines the function but never calls it, so nothing is printed.)

// :type s: str
// :type t: str
// :rtype: bool
static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    // Equivalent of Counter(s) == Counter(t)
    var counterS = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    var counterT = t.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());

    return counterS.Count == counterT.Count &&
           counterS.All(kv => counterT.TryGetValue(kv.Key, out int v) && v == kv.Value);
}
