def XRaisedToY_1(x, y):
    product = 1
    for _ in range(0, y):
        product = product * x

    return product


# x * x * x * x
# x * x
# x
#
def XRaisedToY_2(x, y):
    if y == 1:
        return x
    
    xRaisedToHalfEvenY = XRaisedToY_2(x, y//2)

    if y % 2 == 0:
        return xRaisedToHalfEvenY * xRaisedToHalfEvenY
   
    xRaisedToHalfOddY = XRaisedToY_2(x, (y//2)+1)
    return xRaisedToHalfEvenY * xRaisedToHalfOddY
    

print(XRaisedToY_2(2, 7))