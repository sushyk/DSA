// No driver calls in the original Python file.

// Optimal (for positives and negatives): prefix sum + hashmap, keep the earliest index per prefix sum
static int LongestSubarray_Optimal(int[] nums, int k)
{
    long prefixSum = 0;
    var prefixSumMap = new Dictionary<long, int>();
    int maxLength = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        prefixSum += nums[i];

        if (prefixSum == k)
        {
            int length = i + 1;
            maxLength = Math.Max(maxLength, length);
        }

        long rem = prefixSum - k;
        if (prefixSumMap.TryGetValue(rem, out int idx))
        {
            int length = i - idx;
            maxLength = Math.Max(maxLength, length);
        }

        if (!prefixSumMap.ContainsKey(prefixSum))
            prefixSumMap[prefixSum] = i;
    }

    return maxLength;
}
