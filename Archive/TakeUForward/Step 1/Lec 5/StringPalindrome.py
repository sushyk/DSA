def isStringPalindrome(s: str) -> bool:
    inputStr = s.lower()
    left = 0
    right = len(inputStr) - 1

    while left < right:
        if not inputStr[left].isalnum():
            left += 1  
        if not inputStr[right].isalnum():
            right -= 1

        if inputStr[left] != inputStr[right]:
            return False
        
        if inputStr[left] == inputStr[right]:
            left += 1
            right -= 1
        
    return True

# r,aceca,r

print(isStringPalindrome(" r,a a,r"))