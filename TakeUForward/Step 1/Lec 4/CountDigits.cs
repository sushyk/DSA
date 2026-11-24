Console.WriteLine(CountDigits(100));

static int CountDigits(int n)
{
    // return (int)Math.Floor(Math.Log10(n) + 1);
    int digits = 0;

    while (n > 0)
    {
        digits += 1;
        n = n / 10;
    }

    return digits;
}
