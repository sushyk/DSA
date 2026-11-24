import math

def findDivisors(n: int) -> list[int]:
    divisors = []
    sqrtN = int(math.sqrt(n))

    for i in range(1, sqrtN+1):
        if n % i == 0:
            divisors.append(i)
            counterpart = n // i
            if i != counterpart:
                divisors.append(counterpart)

    return divisors


print(findDivisors(36))