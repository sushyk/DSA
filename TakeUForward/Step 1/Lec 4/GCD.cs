Console.WriteLine(FindGCDBruteForce(23, 17));
Console.WriteLine(FindGCDEuclideanAlgo(33, 9));

static int FindGCDBruteForce(int n1, int n2)
{
    int smaller = Math.Min(n1, n2);
    int gcd = 1;

    for (int i = 1; i <= smaller; i++)
    {
        if (n1 % i == 0 && n2 % i == 0 && i > gcd)
            gcd = i;
    }

    return gcd;
}

static int FindGCDEuclideanAlgo(int a, int b)
{
    if (a == b)
        return a;

    while (a > 0 && b > 0)
    {
        if (a > b)
            a = a % b;
        else
            b = b % a;
    }

    if (a == 0)
        return b;
    else
        return a;
}
