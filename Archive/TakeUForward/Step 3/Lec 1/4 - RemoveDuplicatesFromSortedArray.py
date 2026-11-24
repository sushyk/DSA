# [1,1,1,2,2,2,2,3,3,3,3,4,4]


def removeDuplicates(arr: list[int]) -> int:
    i = 0

    for j in range(len(arr)):
        if arr[j] != arr[i]:
            arr[i+1] = arr[j]
            i += 1

    return i + 1


