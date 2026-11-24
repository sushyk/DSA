Console.WriteLine("[" + string.Join(", ", MoveZerosToStart([1, 2, 0, 3, 0, 0, 4, 5])) + "]");

// [1, 2, 0, 3, 0, 0, 4, 5]

// [0, 0, 0, 1, 2, 3, 4, 5]

static int[] MoveZerosToStart(int[] nums)
{
    int i = -1;

    for (int k = nums.Length - 1; k > -1; k--)
    {
        if (nums[k] == 0)
        {
            i = k;
            break;
        }
    }

    if (i == -1)
    {
        return nums;
    }

    for (int j = i - 1; j > -1; j--)
    {
        if (nums[j] != 0)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
            i -= 1;
        }
    }

    return nums;
}
