def missingNumber(nums):
    """
    :type nums: List[int]
    :rtype: int

    [1, 2, 4] -> 1+2+4 = 7

    [1, 2, 3, 4] -> 1+2+3+4 = 10
    """
    n = len(nums)
    
    sum1 = (n * (n+1)) // 2

    sum2 = 0
    
    for num in nums:
        nsum += num

    return sum1 - sum2