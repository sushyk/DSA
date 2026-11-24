""" 
input: good morning
# output: doog gninrom
#    i,j
#    i          j                    
#                  i,j                      
#                   i                       j
#    g  o   o   d   m   o   r   n   i   n   g
#
# """
def reverseWords(inputStr: str) -> str:
    output = ""

    i, j = 0, 0

    while j < len(inputStr):
        if j == len(inputStr) - 1 or inputStr[j+1] == " ":
            for k in range(j, i-1, -1):
                output += inputStr[k]

            output += " "
            j+=1
            i=j
        else:
            j+=1        

    return output

print(reverseWords("good morning"))