var ps = FindPowerSet([1, 2, 3]);
Console.WriteLine("[" + string.Join(", ", ps.Select(sub => "[" + string.Join(", ", sub) + "]")) + "]");

//   [1, 2, 3]
//   [[], [1], [2], [1, 2], [3], [3], [1, 3], [2, 3], [1, 2, 3]]
//
//   [[]] + [[1]]
//   [[], [1]] + [[2], [1, 2]]
static List<List<int>> FindPowerSet(int[] s)
{
    var powerSet = new List<List<int>> { new() };

    foreach (var elem in s)
    {
        var newElems = new List<List<int>>();
        foreach (var subSet in powerSet)
        {
            newElems.Add([.. subSet, elem]);
        }

        powerSet.AddRange(newElems);
    }

    return powerSet;
}
