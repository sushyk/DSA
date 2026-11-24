from collections import defaultdict
from typing import Counter


def frequencySort(s):
    """
    :type s: str
    :rtype: str

    T R E E
    1 1  2

    1 -> [T, R]
    2 -> EE

    [EE, T, R]

    """

    counter = Counter(s)
    buckets = defaultdict(list)

    for char, freq in counter:
        buckets[freq].append(char)

    ans = []
    for freq in range(len(s), 0, -1):
        if freq in buckets:
            for char in buckets[freq]:
                ans.append(char * freq)

    return "".join(ans)