Console.WriteLine(CheckPrime(18) ? "True" : "False"); // False
Console.WriteLine(CheckPrime(17) ? "True" : "False"); // True
Console.WriteLine(CheckPrime(1) ? "True" : "False");  // False

static bool CheckPrime(int n)
{
    if (n < 2) return false; // fixed: 0 and 1 are not prime

    int sqrtN = (int)Math.Sqrt(n);

    for (int i = 2; i <= sqrtN; i++)
    {
        if (n % i == 0)
            return false;
    }

    return true;
}
