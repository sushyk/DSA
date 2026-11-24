Console.WriteLine("[" + string.Join(", ", ReverseArray([1, 2, 3, 4, 55])) + "]");

static int[] ReverseArray(int[] arr)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left < right)
    {
        (arr[left], arr[right]) = (arr[right], arr[left]);
        left += 1;
        right -= 1;
    }

    return arr;
}
