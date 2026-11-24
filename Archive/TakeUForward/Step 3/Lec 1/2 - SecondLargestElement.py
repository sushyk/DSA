def second(arr: list[int]) -> None:
    n = len(arr)

    if (n == 0 or n == 1):
        print("Second largst", -1)
        print("Second smallest", -1)
        return
    
    largest = float("-inf")
    secondLargest = float("-inf")
    smallest = float("inf")
    secondSmallest = float("inf")

    for i in range(n):
        if arr[i] > largest:
            largest = arr[i]
            secondLargest = largest
        elif arr[i] > secondLargest and arr[i] < largest:
            secondLargest = arr[i]

        if arr[i] < smallest:
            secondSmallest = smallest
            smallest = arr[i]
        elif arr[i] < secondSmallest and arr[i] > smallest:
            secondSmallest = arr[i]
        

    print("Second largest", secondLargest)
    print("Second smallest", secondSmallest)

second([16,12,1,2,4,7,5,7,5])