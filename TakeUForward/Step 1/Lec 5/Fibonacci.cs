for (int i = 0; i < 20; i++)
    Console.WriteLine($"{i} -> {Fib(i)}");

static int Fib(int n)
{
    if (n <= 1)
        return n;

    int first = 0;
    int second = 1;
    int sum = 0;

    for (int i = 2; i <= n; i++)
    {
        sum = (first + second);
        first = second;
        second = sum;
    }

    return sum;
}
