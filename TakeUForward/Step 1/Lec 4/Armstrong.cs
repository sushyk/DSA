Console.WriteLine(IsArmstrong(1634) ? "True" : "False");

Console.WriteLine(1634 / 10);
Console.WriteLine(1634 % 10);

static bool IsArmstrong(int n)
{
    int dup = n;
    int k = n.ToString().Length;
    long sum = 0;

    while (n > 0)
    {
        int lastDigit = n % 10;
        sum += (long)Math.Pow(lastDigit, k);
        n = n / 10;
    }

    return dup == sum;
}
