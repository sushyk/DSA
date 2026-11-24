def beautySum(s):
    """
    :type s: str
    :rtype: int

    aabacc

    a    |  { a: 1 }    1-1 = 0
    aa   |  { a: 2 }    2-2=0
    aab  | { a: 2, b: 1}   2-1=1
    aaba | { a: 3, b: 1}    3-1=2
    """

    sum = 0

    for i in range(len(s)):
        freq = [0] * 26
        for j in range(i, len(s)):
            freq[ord(j) - ord("a")]+=1
            beauty = max(freq) - findMin(freq)
            sum += beauty

    return sum

def findMin(freq):
    minFreq = float("inf")
    for i in range(26):
        if freq[i] < minFreq and freq[i] > 0:
            minFreq = freq[i]

    return minFreq


