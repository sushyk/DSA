#   [1, 2, 3]
#   [[], [1], [2], [1, 2], [3], [3], [1, 3], [2, 3], [1, 2, 3]]
#
#   [[]] + [[1]]
#   [[], [1]] + [[2], [1, 2]]
def findPowerSet(s):
    powerSet = [[]]

    for elem in s:
        newElems = []
        for subSet in powerSet:
            newElems.append(subSet + [elem])

        powerSet.extend(newElems)

    return powerSet

print(findPowerSet([1,2,3]))
