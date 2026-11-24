def mergeAlternately(word1, word2):
    """
    :type word1: str
    :type word2: str
    :rtype: str
    """
    mergedWord = ""

    minLength = min(len(word1), len(word2))

    i = 0
    while i < minLength:
        mergedWord += word1[i]
        mergedWord += word2[i]
        i+=1

    remaining = word1[minLength:] if len(word1) > len(word2) else word2[minLength:] 

    mergedWord += remaining

    return mergedWord


print(mergeAlternately("abcdefgh", "pqrs"))


    