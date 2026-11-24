def hilow(arr: list[int]) -> None:
    map = {}
    for i in range(len(arr)):
        if arr[i] in map:
            map[arr[i]] += 1
        else:
            map[arr[i]] = 1

    maxFreq = 0
    maxElem = None
    minFreq = len(arr)
    minElem = None

    for i in map:
        if map[i] > maxFreq:
            maxFreq = map[i]
            maxElem = i

        if map[i] < minFreq:
            minFreq = map[i]
            minElem = i

    print(maxElem, minElem)

# 10 -> 1
# 11 -> 2
# 12 -> 3

hilow([10, 5, 10, 15, 10, 5])
