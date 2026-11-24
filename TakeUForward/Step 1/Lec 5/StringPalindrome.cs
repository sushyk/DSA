// r,aceca,r

Console.WriteLine(IsStringPalindrome(" r,a a,r") ? "True" : "False");                       // True
Console.WriteLine(IsStringPalindrome("A man, a plan, a canal: Panama") ? "True" : "False"); // True
Console.WriteLine(IsStringPalindrome("ab,,  ,c") ? "True" : "False");                       // False
Console.WriteLine(IsStringPalindrome(".,") ? "True" : "False");                             // True

static bool IsStringPalindrome(string s)
{
    string inputStr = s.ToLower();
    int left = 0;
    int right = inputStr.Length - 1;

    while (left < right)
    {
        // fixed: skip ALL consecutive non-alphanumerics, staying within bounds
        while (left < right && !char.IsLetterOrDigit(inputStr[left]))
            left += 1;
        while (left < right && !char.IsLetterOrDigit(inputStr[right]))
            right -= 1;

        if (inputStr[left] != inputStr[right])
            return false;

        left += 1;
        right -= 1;
    }

    return true;
}
