// Console.WriteLine(MaxProfit([7, 1, 5, 3, 6, 4]));
Console.WriteLine(MaxProfit([7, 8, 9, 10, 1, 55]));

// prices: List[int] -> int
static int MaxProfit(int[] prices)
{
    // l = buy, r
    int l = 0, r = 1;
    int maxProfit = 0;

    while (r < prices.Length)
    {
        if (prices[l] < prices[r])
        {
            int profit = prices[r] - prices[l];
            maxProfit = Math.Max(maxProfit, profit);
        }
        else
        {
            l = r;
        }

        r += 1;
    }

    return maxProfit;
}
