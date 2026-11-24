Console.WriteLine("[" + string.Join(", ", FindDivisors(36)) + "]");

static List<int> FindDivisors(int n)
{
    var divisors = new List<int>();
    int sqrtN = (int)Math.Sqrt(n);

    for (int i = 1; i <= sqrtN; i++)
    {
        if (n % i == 0)
        {
            divisors.Add(i);
            int counterpart = n / i;
            if (i != counterpart)
                divisors.Add(counterpart);
        }
    }

    return divisors;
}
