// No driver calls in the original Python file.

// :type nums: List[int]
// :rtype: int
static int SingleNumber(int[] nums)
{
    int xor = 0;

    foreach (int num in nums)
        xor ^= num;

    return xor;
}
