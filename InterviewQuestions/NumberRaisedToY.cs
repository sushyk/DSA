Console.WriteLine(XRaisedToY_1(2, 7)); // 128
Console.WriteLine(XRaisedToY_2(2, 7)); // 128
Console.WriteLine(XRaisedToY_2(5, 0)); // 1
Console.WriteLine(XRaisedToY_2(3, 13)); // 1594323

static long XRaisedToY_1(long x, int y)
{
    long product = 1;
    for (int _ = 0; _ < y; _++)
    {
        product = product * x;
    }

    return product;
}


// x * x * x * x
// x * x
// x
//
// Fixed: base case y == 0 (was infinite recursion), and reuse the half result
// so it's truly O(log y) instead of making a second recursive call.
static long XRaisedToY_2(long x, int y)
{
    if (y == 0)
    {
        return 1;
    }

    long half = XRaisedToY_2(x, y / 2);

    if (y % 2 == 0)
    {
        return half * half;
    }

    return half * half * x;
}
