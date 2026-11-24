// No driver calls in the original Python file.
// Note: the Python accumulates into an undefined `nsum` (NameError); translated as sum2 (intended).

// :type nums: List[int]
// :rtype: int
//
// [1, 2, 4] -> 1+2+4 = 7
//
// [1, 2, 3, 4] -> 1+2+3+4 = 10
static int MissingNumber(int[] nums)
{
    int n = nums.Length;

    int sum1 = (n * (n + 1)) / 2;

    int sum2 = 0;

    foreach (int num in nums)
        sum2 += num;

    return sum1 - sum2;
}
