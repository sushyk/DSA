// Count substrings with exactly k distinct characters
Console.WriteLine(CountSubstr_Brute("aba", 2));            // 3
Console.WriteLine(new Solution().CountSubstr("aba", 2));   // 3
Console.WriteLine(CountSubstr_Brute("abaaca", 1));         // 7
Console.WriteLine(new Solution().CountSubstr("abaaca", 1)); // 7

static int CountSubstr_Brute(string s, int k)
{
    // your code here
    int count = 0;
    int n = s.Length;

    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n; j++)
        {
            string subStr = s[i..(j + 1)];
            var chars = new HashSet<char>();

            foreach (char ch in subStr)
            {
                if (!chars.Contains(ch))
                    chars.Add(ch);
            }

            if (chars.Count == k)
                count += 1;
        }
    }

    return count;
}

class Solution
{
    public int CountSubstr(string s, int k)
    {
        // your code here
        // (n(k) + n(k-1) + n(k-2) ... n(1)) - (n(k-1) + n(k-2) + ... n(1)) = n(k)
        // NOTE: the Python calls self.atMost(...), which does not exist (the method is atMostK).
        return AtMostK(s, k) - AtMostK(s, k - 1);
    }

    public int AtMostK(string s, int k)
    {
        int l = 0, r = 0;
        int distinctCount = 0;
        int atMostKCount = 0;
        int[] m = new int[26];

        while (r < s.Length)
        {
            m[s[r] - 'a'] += 1;
            if (m[s[r] - 'a'] == 1)
                distinctCount += 1;

            // shorten window
            while (distinctCount > k)
            {
                m[s[l] - 'a'] -= 1;
                // fixed: a char leaves the window when its count drops to 0 (Python had == 1)
                if (m[s[l] - 'a'] == 0)
                    distinctCount -= 1;

                l += 1;
            }

            atMostKCount += (r - l + 1);
            r += 1;
        }

        return atMostKCount;
    }
}
