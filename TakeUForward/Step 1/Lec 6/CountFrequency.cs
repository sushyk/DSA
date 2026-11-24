// fixed: the Python wrapped this in print(), which printed a stray "None"
CountFrequency([10, 5, 10, 15, 10, 5]);

static void CountFrequency(int[] arr)
{
    var map = new Dictionary<int, int>();

    for (int i = 0; i < arr.Length; i++)
    {
        int key = arr[i];
        if (map.ContainsKey(key))
            map[key] += 1;
        else
            map[key] = 1;
    }

    foreach (int k in map.Keys)
        Console.WriteLine($"{k} {map[k]}");
}
