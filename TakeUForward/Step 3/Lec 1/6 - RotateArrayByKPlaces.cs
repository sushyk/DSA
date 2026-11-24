int[] a = [1, 2, 3, 4, 5, 6, 7];
Rotate(a, 8);
Console.WriteLine("[" + string.Join(", ", a) + "]");

// :type nums: List[int]
// :type k: int
// :rtype: None Do not return anything, modify nums in-place instead.
//
// [1, 2, 3, 4, 5, 6, 7], k = 3, n = 8
// [5, 6, 7, 1, 2, 3, 4]
static void Rotate(int[] nums, int k)
{
    int n = nums.Length;
    k = k % n;
    var temp = new List<int>();

    for (int i = n - k; i < n; i++)
        temp.Add(nums[i]);

    for (int i = n - 1 - k; i > -1; i--)
        nums[i + k] = nums[i];

    for (int i = 0; i < k; i++)
        nums[i] = temp[i];
}
