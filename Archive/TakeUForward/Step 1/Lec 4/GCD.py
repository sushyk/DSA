def findGCDBruteForce(n1, n2) -> int:
    smaller = min(n1, n2)
    gcd = 1

    for i in range(1, smaller+1):
        if n1 % i == 0 and n2 % i == 0 and i > gcd:
            gcd = i

    return gcd

def findGCDEuclideanAlgo(a, b) -> int:
    if a == b:
        return a
    
    while a > 0 and b > 0:
        if a > b:
            a = a % b
        else:
            b = b % a

    if a == 0:
        return b
    else:
        return a

print(findGCDBruteForce(23, 17))
print(findGCDEuclideanAlgo(33, 9))
