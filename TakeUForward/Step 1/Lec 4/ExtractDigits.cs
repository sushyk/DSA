Console.WriteLine("[" + string.Join(", ", ExtractDigits(1234)) + "]");

static List<int> ExtractDigits(int n)
{
    var stack = new List<int>();

    while (n > 0)
    {
        int lastDigit = n % 10;
        stack.Add(lastDigit);
        n = n / 10;
    }

    stack.Reverse();

    return stack;
}
