import math

def checkPrime(n: int) -> bool:
    sqrtN = int(math.sqrt(n))

    for i in range(2, sqrtN+1):
        if n % i == 0:
            return False
        
    return True

print(checkPrime(18))