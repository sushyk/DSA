Console.WriteLine(ReverseWords("good morning"));

// input: good morning
// output: doog gninrom
//    i,j
//    i          j
//                  i,j
//                   i                       j
//    g  o   o   d   m   o   r   n   i   n   g
//
static string ReverseWords(string inputStr)
{
    string output = "";

    int i = 0, j = 0;

    while (j < inputStr.Length)
    {
        if (j == inputStr.Length - 1 || inputStr[j + 1] == ' ')
        {
            for (int k = j; k > i - 1; k--)
            {
                output += inputStr[k];
            }

            output += " ";
            j += 1;
            i = j;
        }
        else
        {
            j += 1;
        }
    }

    return output;
}
