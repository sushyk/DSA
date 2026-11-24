def fib(n):
    if n <= 1:
        return n
    
    first = 0
    second = 1

    for i in range(2, n+1):
        sum = (first + second)
        first = second
        second = sum

    return sum

for i in range(20):
    print(i, "->", fib(i))
