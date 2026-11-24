Console.WriteLine("[" + string.Join(", ", MoveZerosToEnd(4, [0, 1, 0, 1])) + "]");

static int[] MoveZerosToEnd(int n, int[] a)
{
    int j = -1;
    // Place the pointer j
    for (int i = 0; i < n; i++)
    {
        if (a[i] == 0)
        {
            j = i;
            break;
        }
    }

    // No non-zero elements
    if (j == -1)
        return a;

    // Move the pointers i and j and swap accordingly
    for (int i = j + 1; i < n; i++)
    {
        if (a[i] != 0)
        {
            (a[i], a[j]) = (a[j], a[i]);
            j += 1;
        }
    }

    return a;
}
