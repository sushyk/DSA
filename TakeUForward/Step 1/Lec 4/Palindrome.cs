MainFn();

// Function to check if a
// given integer is a palindrome
static bool Palindrome(int n)
{
    int revNum = 0;
    int originalNum = n;

    while (n > 0)
    {
        int ld = n % 10;
        revNum = (revNum * 10) + ld;
        n = n / 10;
    }

    return originalNum == revNum;
}

static void MainFn() // Python: main()
{
    int number = 122;

    Console.WriteLine(Palindrome(number).ToString().ToLower());
}
