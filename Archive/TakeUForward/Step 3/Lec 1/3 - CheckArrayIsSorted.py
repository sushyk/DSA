def checkArray(arr: list[int]) -> bool:
    for i in range(len(arr)-1):
        if arr[i+1] < arr[i]:
            return False
        
    return True

def checkArrayIsSortedAndRotated(nums):
    """
    :type nums: List[int]
    :rtype: bool
    """
    n = len(nums)
    if n == 0 or n == 1 or n == 2:
        return True

    isRotated = nums[n-1] <= nums[0]
    decreaseCount = 0

    for i in range(n-1):
        if nums[i+1] < nums[i]:
            decreaseCount += 1

    return (not isRotated and decreaseCount == 0) or (isRotated and decreaseCount <= 1)


print(checkArrayIsSortedAndRotated([2,1,3,4]))