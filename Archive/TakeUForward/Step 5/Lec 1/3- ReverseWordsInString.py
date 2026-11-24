def reverseWords(s):
    """
    :type s: str
    :rtype: str
    """

    wordsArray = s.split()

    l, r = 0, len(wordsArray) - 1

    while l < r:
        wordsArray[l], wordsArray[r] = wordsArray[r], wordsArray[l]
        l += 1
        r -= 1


    return " ".join(wordsArray)


print(reverseWords(" hello world sushil  "))



        

    