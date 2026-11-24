
# [1, 2, 0, 3, 0, 0, 4, 5]

# [0, 0, 0, 1, 2, 3, 4, 5]


def moveZerosToStart(nums: list[int]) -> list[int]:
    i = -1

    for k in range(len(nums)-1, -1, -1):
        if nums[k] == 0:
            i = k
            break
    
    if i == -1:
        return nums
    
    for j in range(i-1, -1, -1):
        if nums[j] != 0:
            nums[i], nums[j] = nums[j], nums[i]
            i-=1

    return nums

print(moveZerosToStart([1, 2, 0, 3, 0, 0, 4, 5]))
        