// (The Python file defines the function only and makes no calls, so this prints nothing.)
#pragma warning disable CS8321 // local function declared but never used

static int SumOfAllDivisors(int n)
{
    int sum = 0;
    // Write your code here
    int sqrtN = (int)Math.Sqrt(n);

    for (int i = 1; i <= sqrtN; i++)
    {
        if (n % i == 0)
        {
            sum += i;
            if (i != (n / i))
                sum += (n / i);
        }
    }

    return sum;
}
