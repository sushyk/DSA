def countFrequency(arr: list[int]) -> None:
    map = {}

    for i in range(len(arr)):
        key = arr[i]
        if key in map:
            map[key] += 1
        else:
            map[key] = 1

    for k in map.keys():
        print(k, map[k])

print(countFrequency([10, 5, 10, 15, 10, 5]))
