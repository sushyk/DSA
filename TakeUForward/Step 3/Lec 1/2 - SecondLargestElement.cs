Second([16, 12, 1, 2, 4, 7, 5, 7, 5]);

// Expected: Second largest 12, Second smallest 2
static void Second(int[] arr)
{
    int n = arr.Length;

    if (n == 0 || n == 1)
    {
        Console.WriteLine("Second largst " + -1);
        Console.WriteLine("Second smallest " + -1);
        return;
    }

    double largest = double.NegativeInfinity;
    double secondLargest = double.NegativeInfinity;
    double smallest = double.PositiveInfinity;
    double secondSmallest = double.PositiveInfinity;

    for (int i = 0; i < n; i++)
    {
        if (arr[i] > largest)
        {
            secondLargest = largest; // fixed: demote old largest before overwriting
            largest = arr[i];
        }
        else if (arr[i] > secondLargest && arr[i] < largest)
        {
            secondLargest = arr[i];
        }

        if (arr[i] < smallest)
        {
            secondSmallest = smallest;
            smallest = arr[i];
        }
        else if (arr[i] < secondSmallest && arr[i] > smallest)
        {
            secondSmallest = arr[i];
        }
    }

    Console.WriteLine("Second largest " + Fmt(secondLargest));
    Console.WriteLine("Second smallest " + Fmt(secondSmallest));
}

// Python-like printing of an int or float infinity
static string Fmt(double v) =>
    double.IsPositiveInfinity(v) ? "inf" : double.IsNegativeInfinity(v) ? "-inf" : ((long)v).ToString();
