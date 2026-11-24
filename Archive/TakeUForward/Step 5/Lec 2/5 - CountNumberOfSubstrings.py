def countSubstr_Brute(s, k):
    # your code here
    count = 0
    n = len(s)
    
    for i in range(n):
        for j in range(i, n):
            subStr = s[i:j+1]
            chars = set()
            
            for ch in subStr:
                if ch not in chars:
                    chars.add(ch)
                    
            if len(chars) == k:
                count += 1
            
            
    return count

class Solution:
    def countSubstr(self, s, k):
        # your code here
        # (n(k) + n(k-1) + n(k-2) ... n(1)) - (n(k-1) + n(k-2) + ... n(1)) = n(k)
        return self.atMost(s, k) - self.atMost(s, k-1)
        
    def atMostK(self, s, k):
        l, r = 0, 0
        distinctCount = 0
        atMostKCount = 0
        m = [0] * 26

        while r < len(s):
            m[ord(s[r]) - ord('a')] += 1
            if m[ord(s[r]) - ord('a')] == 1:
                distinctCount += 1
    
            # shorten window
            while distinctCount > k:
                m[ord(s[l]) - ord('a')] -= 1
                if m[ord(s[l]) - ord('a')] == 1:
                    distinctCount -= 1

                l += 1

            atMostKCount += (r - l + 1)
            r += 1

        return atMostKCount

