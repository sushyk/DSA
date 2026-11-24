Console.WriteLine(FindMaxAverage([1, 12, -5, -6, 50, 3], 4));

// nums: List[int], k: int -> float
static double FindMaxAverage(int[] nums, int k)
{
    int i = 0;
    int j = i + (k - 1);
    double maxAvg = double.NegativeInfinity;

    while (j < nums.Length)
    {
        int[] subArray = nums[i..(j + 1)];
        double currAvg = (double)subArray.Sum() / subArray.Length;
        maxAvg = Math.Max(maxAvg, currAvg);
        i += 1;
        j += 1;
    }

    return maxAvg;
}
