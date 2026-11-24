Console.WriteLine("[" + string.Join(", ", SortedArray([3, 5], [])) + "]");             // [3, 5]
Console.WriteLine("[" + string.Join(", ", SortedArray([1, 2, 4], [1, 3, 5, 6])) + "]"); // [1, 2, 3, 4, 5, 6]
Console.WriteLine("[" + string.Join(", ", SortedArray([1, 1, 2], [2, 2, 3])) + "]");    // [1, 2, 3]

// Union of two sorted arrays (distinct elements, sorted).
// Fixed: tail loops now check the correct array bounds and skip duplicates.
static List<int> SortedArray(int[] a, int[] b)
{
    // Write your code here
    // 1 2 4
    // 1 3 5
    var union = new List<int>();

    int i = 0;
    int j = 0;

    while (i < a.Length && j < b.Length)
    {
        if (a[i] <= b[j])
        {
            AddIfNew(union, a[i]);
            if (a[i] == b[j]) j += 1;
            i += 1;
        }
        else
        {
            AddIfNew(union, b[j]);
            j += 1;
        }
    }

    while (i < a.Length)
    {
        AddIfNew(union, a[i]);
        i += 1;
    }

    while (j < b.Length)
    {
        AddIfNew(union, b[j]);
        j += 1;
    }

    return union;
}

static void AddIfNew(List<int> union, int num)
{
    if (union.Count == 0 || union[^1] != num)
        union.Add(num);
}
