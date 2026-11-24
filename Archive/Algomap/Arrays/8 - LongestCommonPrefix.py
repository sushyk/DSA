def longestCommonPrefix(strs):
    """
    :type strs: List[str]
    :rtype: str
    """

    minLength = float("inf")

    for s in strs:
        if len(s) < minLength:
            minLength = len(s)

    i = 0
    while i < minLength:
        for s in strs:
            if s[i] != strs[0][i]:
                return strs[0][:i]
        i+=1

    return strs[0][:i]