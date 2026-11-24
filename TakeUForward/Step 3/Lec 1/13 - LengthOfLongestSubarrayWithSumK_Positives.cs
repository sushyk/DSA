// No driver calls in the original Python file.

// Better: prefix sum + hashmap
static int LongestSubarray_Better(int[] nums, int k)
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

        prefixSumMap[prefixSum] = i;
    }

    return maxLength;
}

// Optimal: two pointers / sliding window (positives only)
// Note: the Python does `sum += nums[right]` after `right += 1` without a bounds check,
// which raises IndexError on the last iteration; a guard is added here.
static int LongestSubarray_Optimal(int[] nums, int k)
{
    int maxLength = 0;
    int left = 0;
    int right = 0;
    long sum = nums[0];

    while (right < nums.Length)
    {
        while (sum > k && left <= right)
        {
            sum -= nums[left];
            left += 1;
        }

        if (sum == k)
            maxLength = Math.Max(maxLength, right - left + 1);

        right += 1;
        if (right < nums.Length)
            sum += nums[right];
    }

    return maxLength;
}
