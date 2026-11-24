import math

def sumOfAllDivisors(n: int) -> int:
    sum = 0
    # Write your code here
    sqrtN = int(math.sqrt(n))

    for i in range(1, sqrtN + 1):
        if n % i == 0:
            sum += i
            if i != (n//i):
                sum += (n//i)

    return sum