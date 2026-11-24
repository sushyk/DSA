def maxProfit(prices):
    """
    :type prices: List[int]
    :rtype: int
    """
    # l = buy, r
    l, r = 0, 1 
    maxProfit = 0

    while r < len(prices):
        if prices[l] < prices[r]:
            profit = prices[r] - prices[l]
            maxProfit = max(maxProfit, profit)
        else:
            l = r

        r += 1

    return maxProfit


# print(maxProfit([7, 1, 5, 3, 6, 4]))
print(maxProfit([7, 8, 9, 10, 1, 55]))