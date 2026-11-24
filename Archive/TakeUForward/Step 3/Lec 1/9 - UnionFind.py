def sortedArray(a: list[int], b: list[int]) -> list[int]:
    # Write your code here
    # 1 2 4
    # 1 3 5
    union = []

    i = 0
    j = 0

    while i < len(a) and j < len(b):
        if a[i] < b[j]:
            union.append(a[i])
            i += 1
        elif a[i] == b[j]:
            union.append(a[i])
            i += 1
            j += 1
        else:
            union.append(b[j])
            j += 1
              

    if j < len(a):
        for num in b[j:]:
            union.append(num)

    if i < len(a):
        for num in a[i-1:]:
            union.append(num)


    return union

print(sortedArray([5, 3], []))