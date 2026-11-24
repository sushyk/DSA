def extractDigits(n: int) -> list[int]:
    stack = []

    while n > 0:
        lastDigit = n % 10
        stack.append(lastDigit)
        n = n // 10

    stack.reverse()

    return stack

print(extractDigits(1234))