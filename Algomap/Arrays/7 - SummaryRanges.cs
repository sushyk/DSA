var result = SummaryRanges([0, 1, 2, 4, 5, 7]);
Console.WriteLine("[" + string.Join(", ", result.Select(s => $"'{s}'")) + "]");

// nums: List[int] -> List[str]
static List<string> SummaryRanges(int[] nums)
{
    var ans = new List<string>();
    int i = 0;

    while (i < nums.Length)
    {
        int start = nums[i];

        while (i < nums.Length - 1 && nums[i] + 1 == nums[i + 1])
        {
            i += 1;
        }

        if (start != nums[i])
        {
            ans.Add(start.ToString() + "->" + nums[i].ToString());
        }
        else
        {
            ans.Add(nums[i].ToString());
        }

        i += 1;
    }

    return ans;
}
