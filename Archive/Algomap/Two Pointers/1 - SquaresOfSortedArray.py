
def sortedSquares(nums):
    """
    :type nums: List[int]
    :rtype: List[int]
    """
    squares = []
    l = 0
    r = len(nums) - 1

    while l <= r:
        lsquare = nums[l] ** 2
        rsquare = nums[r] ** 2

        if lsquare > rsquare:
            squares.append(lsquare)
            l+=1
        else:
            squares.append(rsquare)
            r-=1

    return squares

print(sortedSquares([-4, -1, 0, 3, 10]))

print(sortedSquares([4, 1, 0, 3, 10]))
    