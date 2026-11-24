
def isSubsequence(s, t):
    """
    :type s: str
    :type t: str
    :rtype: bool
    """
    if s == "" and len(t) >= 0:
        return True
    elif len(s) > 0 and t == "":
        return False
    else:
        i,j = 0, 0
    
        while i < len(s) and j < len(t):
            if t[j] == s[i]:
                i+=1
            j+=1

        return i == len(s)


