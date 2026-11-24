#                *
#             *  *
#          *  *  *
#       *  *  *  *  
#    *  *  *  *  *
#  * *  *  *  *  *
def triangle():
    for i in range(1, 7):
        # print spaces
        spaces = 6 - i
        for _ in range(0, spaces):
            print(" ", end=" ")

        # print stars
        stars = i
        for _ in range(0, stars):
            print("*", end=" ")

        print("\n")


print(triangle())