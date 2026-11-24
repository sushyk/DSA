#pragma warning disable CS8321 // functions are defined but not called (same as the Python)
// (The Python file defines the function but never calls it, so nothing is printed.)

// :type s: str
// :rtype: str
//
// T R E E
// 1 1  2
//
// 1 -> [T, R]
// 2 -> EE
//
// [EE, T, R]
static string FrequencySort(string s)
{
    // Counter(s) - insertion ordered like Python's dict
    var counter = new Dictionary<char, int>();
    foreach (char c in s)
        counter[c] = counter.GetValueOrDefault(c) + 1;

    var buckets = new Dictionary<int, List<char>>();

    // NOTE: the Python writes `for char, freq in counter:` which iterates keys only and
    // raises ValueError at runtime; the intended `counter.items()` is translated here.
    foreach (var (ch, freq) in counter)
    {
        if (!buckets.ContainsKey(freq))
            buckets[freq] = new List<char>();
        buckets[freq].Add(ch);
    }

    var ans = new List<string>();
    for (int freq = s.Length; freq > 0; freq--)
    {
        if (buckets.ContainsKey(freq))
        {
            foreach (char ch in buckets[freq])
                ans.Add(new string(ch, freq));
        }
    }

    return string.Join("", ans);
}
