// No driver calls in the original Python file.
// Note: the Python never returns maxCount (implicitly returns None); the intended return is added here.

// :type nums: List[int]
// :rtype: int
static int FindMaxConsecutiveOnes(int[] nums)
{
    int maxCount = 0;
    int count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 1)
        {
            count += 1;
            maxCount = Math.Max(maxCount, count);
        }
        else
        {
            count = 0;
        }
    }

    return maxCount;
}
