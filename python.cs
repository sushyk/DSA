// Console.Write("Enter a number: "); int n = int.Parse(Console.ReadLine()!);

// if (n > 0)
//     Console.WriteLine("The number is greater than 0");
// else if (n < 0)
//     Console.WriteLine("the number is less than 0");
// else
//     Console.WriteLine("The number is equal to 0");

// int m = 0;
// while (m <= 5)
// {
//     Console.WriteLine(m);
//     m += 1;
// }

// for (int i = 1; i < 5; i++)
//     Console.WriteLine(i);

// Console.WriteLine(5 / 2.0);
// Console.WriteLine(5 / 2);

// Console.WriteLine(Math.Pow(5, -2));

// for (int i = 0; i < nums.Length; i++)
//     Console.WriteLine(i);

// foreach (var n in nums)
//     Console.WriteLine(n);

// foreach (var (n, i) in nums.Select((n, i) => (n, i)))
//     Console.WriteLine($"index= {i} number= {n}");

// var words = new List<string> { "bob", "alice", "jennifer", "denny" };
// words.Sort();
// Console.WriteLine("[" + string.Join(", ", words) + "]");
// words = words.OrderByDescending(x => x.Length).ToList();
// Console.WriteLine("[" + string.Join(", ", words) + "]");

// var arr1 = Enumerable.Range(2, 19).Where(i => (i - 2) % 2 == 0).ToList(); // range(2, 21, 2)
// Console.WriteLine("[" + string.Join(", ", arr1) + "]");

// string s = "There is a little red fox";
// string[] sarr = s.Split(" ");
// Console.WriteLine("[" + string.Join(", ", sarr) + "]");
// Console.WriteLine(string.Join(" ", sarr));

// var mySet = new HashSet<int>();
// mySet.Add(3);
// mySet.Add(2);
// mySet.Add(1);

// Console.WriteLine("{" + string.Join(", ", mySet) + "}");

// var mySet = Enumerable.Range(0, 5).ToHashSet();
// if (mySet.Contains(3))
// {
//     mySet.Add(-7);
//     Console.WriteLine("{" + string.Join(", ", mySet) + "}");
// }

// var myMap = new Dictionary<int, string> { [1] = "hello", [2] = "world" };
// myMap.Remove(1);
// Console.WriteLine(myMap[2]);

// var myMap = Enumerable.Range(0, 5).ToDictionary(i => i, i => Math.Pow(i, i).ToString());
// Console.WriteLine("{" + string.Join(", ", myMap.Select(kv => $"{kv.Key}: '{kv.Value}'")) + "}");

// static int MultiplyAndAdd(int n, int m)
// {
//     int Multiply(int i, int j)
//     {
//         return i * j;
//     }
//
//     int Add()
//     {
//         return n + m + Multiply(n, m);
//     }
//
//     return Add();
// }

// Console.WriteLine(MultiplyAndAdd(3, 9));

// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 5; j++)
//         Console.Write("*");
//     Console.WriteLine();
// }

// from collections import Counter -> GroupBy/CountBy (System.Linq)


// Console.WriteLine("[" + string.Join(", ", new[] { 1, 2 }.Concat(new[] { 3, 4 })) + "]");
var counter = new[] { "a", "a", "b" }.CountBy(x => x).OrderByDescending(kv => kv.Value);
Console.WriteLine("Counter({" + string.Join(", ", counter.Select(kv => $"'{kv.Key}': {kv.Value}")) + "})");
