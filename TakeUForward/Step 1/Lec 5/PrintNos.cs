// fixed: the Python wrapped this in print(), which printed a stray "None"
PrintNos(5);
Console.WriteLine();

static void PrintNos(int n)
{
    if (n == 0)
        return;

    PrintNos(n - 1);
    Console.Write(n + " ");
}
