def rotate(nums, k):
    """
    :type nums: List[int]
    :type k: int
    :rtype: None Do not return anything, modify nums in-place instead.

    [1, 2, 3, 4, 5, 6, 7], k = 3, n = 8
    [5, 6, 7, 1, 2, 3, 4]
    """
    n = len(nums)
    k = k % n
    temp = []

    for i in range(n-k, n):
        temp.append(nums[i])

    for i in range(n-1-k, -1, -1):
        nums[i+k] = nums[i]

    for i in range(k):
        nums[i] = temp[i]

a = [1,2,3,4,5,6,7]
rotate(a, 8)
print(a)