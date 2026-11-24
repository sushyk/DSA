def longestSubarray_Optimal (nums: list[int], k: int) -> int:
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

        if prefixSum not in prefixSumMap:
            prefixSumMap[prefixSum] = i

    return maxLength