def myAtoi(s):
    """
    :type s: str
    :rtype: int
    """

    minBound = -2 ** 31
    maxBound = (2 ** 31)-1
    num = 0

    i = 0
    n = len(s)
    sign = 1

    while i < n and s[i] == " ":
        i += 1

    if i < n:
        if s[i] == "-":
            sign = -1
            i+=1
        elif s[i] == "+":
            sign = 1
            i+=1
    
    while i < n and s[i].isdigit() and int(s[i]) == 0:
        i += 1

    while i < n and s[i].isdigit():
        num = num * 10 + int(s[i])
        i += 1


    num = num * sign

    if num > maxBound:
        return maxBound
    elif num < minBound:
        return minBound
    else:
        return num


print(myAtoi("-91283472332"))