def reverseWords(s):
    """
    :type s: str
    :rtype: str

    """
    sArray = s.split()

    l, r = 0, len(sArray) - 1

    while l <= r:
        sArray[l], sArray[r] = sArray[r], sArray[l]
        l+=1
        r-=1

    return " ".join(sArray)

