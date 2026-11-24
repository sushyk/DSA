def searchInSorted(arr, k):
    for i in range(len(arr)):
        if arr[i] == k:
            return True
    
    return False