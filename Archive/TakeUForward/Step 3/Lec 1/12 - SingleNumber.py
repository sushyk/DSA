def singleNumber(nums):
    """
    :type nums: List[int]
    :rtype: int
    """

    xor = 0

    for num in nums:
        xor ^= num

    return xor