import math

def countDigits(n: int) -> int:

    # return math.floor(math.log10(n) + 1);
    digits = 0

    while n > 0:
        digits += 1
        n = n // 10

    return digits

print(countDigits(100))
    