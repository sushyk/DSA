# n = int(input("Enter a number: "))

# if n > 0:
#     print('The number is greater than 0')
# elif n < 0:
#     print("the number is less than 0")
# else:
#     print("The number is equal to 0")

# m = 0
# while m <= 5:
#     print(m)
#     m+=1

# for i in range(1, 5):
#     print(i)

# print(5 / 2)
# print(5 // 2)

# print(5 ** -2)

# for i in range(len(nums)):
#     print(i)

# for n in nums:
#     print(n)

# for i, n in enumerate(nums):
#     print("index=", i, "number=", n)

# words = ["bob", "alice", "jennifer", "denny"]
# words.sort()
# print(words)
# words.sort(key=lambda x: len(x), reverse=True)
# print(words)

# arr1 = [i for i in range(2, 21, 2)]
# print(arr1)

# s = "There is a little red fox"
# sarr = s.split(" ")
# print(sarr)
# print(" ".join(sarr))

# mySet = set()
# mySet.add(3)
# mySet.add(2)
# mySet.add(1)

# print(mySet)

# mySet = { i for i in range(5) }
# if 3 in mySet:
#     mySet.add(-7)
#     print(mySet)

# myMap = { 1: "hello", 2: "world" }
# myMap.pop(1)
# print(myMap[2])

# myMap = { i: str(i ** i) for i in range(5) }
# print(myMap)

# def multiplyAndAdd(n, m):
#     def multiply(i ,j):
#         return i * j
    
#     def add():
#         return n + m + multiply(n, m)
    
#     return add()

# print(multiplyAndAdd(3, 9))

# for i in range(5):
#     for j in range(5):
#         print("*", end="")
#     print()

from collections import Counter


# print([1,2] + [3, 4])
print(Counter(["a", "a", "b"]))