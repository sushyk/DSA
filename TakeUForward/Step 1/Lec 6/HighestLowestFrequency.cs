// 10 -> 1
// 11 -> 2
// 12 -> 3

Hilow([10, 5, 10, 15, 10, 5]);

static void Hilow(int[] arr)
{
    var map = new Dictionary<int, int>();
    for (int i = 0; i < arr.Length; i++)
    {
        if (map.ContainsKey(arr[i]))
            map[arr[i]] += 1;
        else
            map[arr[i]] = 1;
    }

    int maxFreq = 0;
    int? maxElem = null;
    int minFreq = arr.Length;
    int? minElem = null;

    foreach (int i in map.Keys)
    {
        if (map[i] > maxFreq)
        {
            maxFreq = map[i];
            maxElem = i;
        }

        if (map[i] < minFreq)
        {
            minFreq = map[i];
            minElem = i;
        }
    }

    Console.WriteLine($"{maxElem?.ToString() ?? "None"} {minElem?.ToString() ?? "None"}");
}
