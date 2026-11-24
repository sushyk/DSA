Console.WriteLine("[" + string.Join(", ", SortedSquares([-4, -1, 0, 3, 10])) + "]");  // [0, 1, 9, 16, 100]

Console.WriteLine("[" + string.Join(", ", SortedSquares([-7, -3, 2, 3, 11])) + "]");  // [4, 9, 9, 49, 121]

// nums: List[int] -> List[int]
static List<int> SortedSquares(int[] nums)
{
    var squares = new List<int>();
    int l = 0;
    int r = nums.Length - 1;

    while (l <= r)
    {
        int lsquare = nums[l] * nums[l];
        int rsquare = nums[r] * nums[r];

        if (lsquare > rsquare)
        {
            squares.Add(lsquare);
            l += 1;
        }
        else
        {
            squares.Add(rsquare);
            r -= 1;
        }
    }

    squares.Reverse(); // fixed: largest squares were collected first
    return squares;
}
