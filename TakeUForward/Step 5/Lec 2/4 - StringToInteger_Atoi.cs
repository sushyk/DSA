Console.WriteLine(MyAtoi("-91283472332"));

// :type s: str
// :rtype: int
static long MyAtoi(string s)
{
    long minBound = -(1L << 31);
    long maxBound = (1L << 31) - 1;
    long num = 0;

    int i = 0;
    int n = s.Length;
    int sign = 1;

    while (i < n && s[i] == ' ')
        i += 1;

    if (i < n)
    {
        if (s[i] == '-')
        {
            sign = -1;
            i += 1;
        }
        else if (s[i] == '+')
        {
            sign = 1;
            i += 1;
        }
    }

    while (i < n && char.IsAsciiDigit(s[i]) && s[i] - '0' == 0)
        i += 1;

    while (i < n && char.IsAsciiDigit(s[i]))
    {
        num = num * 10 + (s[i] - '0');
        i += 1;
        // Python ints are unbounded; cap here (the result is clamped anyway) to avoid long overflow
        if (num > maxBound + 1)
            num = maxBound + 1;
    }

    num = num * sign;

    if (num > maxBound)
        return maxBound;
    else if (num < minBound)
        return minBound;
    else
        return num;
}
