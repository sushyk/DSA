// No driver calls in the original Python file.

static bool SearchInSorted(int[] arr, int k)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == k)
            return true;
    }

    return false;
}
