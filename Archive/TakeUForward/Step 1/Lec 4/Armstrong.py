from collections import deque


def isArmstrong(n):
    dup = n
    k = len(str(n))
    sum = 0

    while n > 0:
        lastDigit = n % 10
        sum += lastDigit ** k
        n = n // 10

    return dup == sum

print(isArmstrong(1634))

print(1634 // 10)
print(1634 % 10)
