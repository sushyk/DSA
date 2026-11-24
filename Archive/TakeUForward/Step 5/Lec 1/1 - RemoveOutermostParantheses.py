def removeOuterParentheses(s):
    """
    :type s: str
    :rtype: str
    """

    if s == "":
        return s
    
    count = 0
    output = ""

    for ch in s:
        if ch == "(":
            count += 1
            if count > 1:
                output += ch
        elif ch == ")":
            count -= 1 
            if count > 0:
                output += ch
                  
    return output

print(removeOuterParentheses("(()())(())"))