def isIsomorphic(s, t):
    """
    :type s: str
    :type t: str
    :rtype: bool
    """
    hashmapST = {}
    hashmapTS = {}

    for c1, c2 in zip(s, t):
        if (
            (c1 in hashmapST and hashmapST[c1] != c2) or
            (c2 in hashmapTS and hashmapTS[c2] != c1)
            ):
            return False

        hashmapST[c1] = c2
        hashmapTS[c2] = c1

    return True

print(isIsomorphic("badc", "baba"))
        