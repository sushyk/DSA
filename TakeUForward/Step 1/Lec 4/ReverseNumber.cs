// (The Python file defines the function only and makes no calls, so this prints nothing.)
#pragma warning disable CS8321 // local function declared but never used

static int Reverse(int n)
{
    int reverseNum = 0;

    while (n > 0)
    {
        int lastDigit = n % 10;
        reverseNum = (reverseNum * 10) + lastDigit;
        n = n / 10;
    }

    return reverseNum;
}
