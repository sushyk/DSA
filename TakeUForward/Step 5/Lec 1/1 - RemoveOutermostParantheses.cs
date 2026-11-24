Console.WriteLine(RemoveOuterParentheses("(()())(())"));

// :type s: str
// :rtype: str
static string RemoveOuterParentheses(string s)
{
    if (s == "")
        return s;

    int count = 0;
    string output = "";

    foreach (char ch in s)
    {
        if (ch == '(')
        {
            count += 1;
            if (count > 1)
                output += ch;
        }
        else if (ch == ')')
        {
            count -= 1;
            if (count > 0)
                output += ch;
        }
    }

    return output;
}
