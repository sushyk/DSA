Console.WriteLine(CheckArrayIsSortedAndRotated([2, 1, 3, 4]) ? "True" : "False");

static bool CheckArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i + 1] < arr[i])
            return false;
    }

    return true;
}

// :type nums: List[int]
// :rtype: bool
static bool CheckArrayIsSortedAndRotated(int[] nums)
{
    int n = nums.Length;
    if (n == 0 || n == 1 || n == 2)
        return true;

    bool isRotated = nums[n - 1] <= nums[0];
    int decreaseCount = 0;

    for (int i = 0; i < n - 1; i++)
    {
        if (nums[i + 1] < nums[i])
            decreaseCount += 1;
    }

    return (!isRotated && decreaseCount == 0) || (isRotated && decreaseCount <= 1);
}
