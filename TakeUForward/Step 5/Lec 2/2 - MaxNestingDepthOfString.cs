#pragma warning disable CS8321 // functions are defined but not called (same as the Python)
// (The Python file defines the function but never calls it, so nothing is printed.)

// :type s: str
// :rtype: int
static int MaxDepth(string s)
{
    int depth = 0;
    int maxDepth = 0;

    foreach (char ch in s)
    {
        if (ch == '(')
        {
            depth += 1;
            maxDepth = Math.Max(depth, maxDepth);
        }
        else if (ch == ')')
        {
            depth -= 1;
        }
    }

    return maxDepth;
}
