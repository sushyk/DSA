#pragma warning disable CS8321 // functions are defined but not called (same as the Python)
// (The Python file defines the function but never calls it, so nothing is printed.)

// :type s: str
// :rtype: int
//
// aabacc
//
// a    |  { a: 1 }    1-1 = 0
// aa   |  { a: 2 }    2-2=0
// aab  | { a: 2, b: 1}   2-1=1
// aaba | { a: 3, b: 1}    3-1=2
static int BeautySum(string s)
{
    int sum = 0;

    for (int i = 0; i < s.Length; i++)
    {
        int[] freq = new int[26];
        for (int j = i; j < s.Length; j++)
        {
            // NOTE: the Python uses ord(j) (j is an int -> TypeError); intended s[j].
            freq[s[j] - 'a'] += 1;
            int beauty = freq.Max() - FindMin(freq);
            sum += beauty;
        }
    }

    return sum;
}

static int FindMin(int[] freq)
{
    int minFreq = int.MaxValue;
    for (int i = 0; i < 26; i++)
    {
        if (freq[i] < minFreq && freq[i] > 0)
            minFreq = freq[i];
    }

    return minFreq;
}
