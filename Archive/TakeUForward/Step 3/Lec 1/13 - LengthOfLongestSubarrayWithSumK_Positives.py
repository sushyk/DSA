def longestSubarray_Better(nums: list[int], k: int) -> int:
    prefixSum = 0
    prefixSumMap = {}
    maxLength = 0

    for i in range(len(nums)):
        prefixSum += nums[i]

        if prefixSum == k:
            length = i + 1
            maxLength = max(maxLength, length)

        rem = prefixSum - k
        if rem in prefixSumMap:
            length = i - prefixSumMap[rem]
            maxLength = max(maxLength, length)

        prefixSumMap[prefixSum] = i

    return maxLength

def longestSubarray_Optimal(nums: list[int], k: int) -> int:

    maxLength = 0
    left = 0
    right = 0
    sum = nums[0]

    while right < len(nums):

        while sum > k and left <= right:
            sum -= nums[left]
            left+=1

        if sum == k:
            maxLength = max(maxLength, right - left + 1)

        right += 1
        sum += nums[right]

    return maxLength