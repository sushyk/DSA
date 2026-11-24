                            
# Function to check if a
# given integer is a palindrome
def palindrome(n):
    revNum = 0
    originalNum = n

    while n > 0:
        ld = n % 10
        revNum = (revNum * 10) + ld
        n = n // 10

    return originalNum == revNum


def main():
    number = 122

    print(str(palindrome(number)).lower())


if __name__ == "__main__":
    main()
                           
                        