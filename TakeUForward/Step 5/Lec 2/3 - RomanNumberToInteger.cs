#pragma warning disable CS8321 // functions are defined but not called (same as the Python)
// (The Python file defines the function but never calls it, so nothing is printed.)

static int RomanToInteger(string s)
{
    var map = new Dictionary<char, int>
    {
        { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
    };
    int sum = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (i < s.Length - 1 && map[s[i]] < map[s[i + 1]])
            sum -= map[s[i]];
        else
            sum += map[s[i]];
    }

    return sum;
}
