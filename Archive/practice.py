
def findMaxAverage(nums, k):
    """
    :type nums: List[int]
    :type k: int
    :rtype: float
    """
    
    i = 0
    j = i + (k-1)
    maxAvg = float("-inf")

    while j < len(nums):
        subArray = nums[i:j+1]
        currAvg = sum(subArray) / len(subArray)
        maxAvg = max(maxAvg, currAvg)
        i+=1
        j+=1

    return maxAvg

print(findMaxAverage([1,12,-5,-6,50,3], 4))