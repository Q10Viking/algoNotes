def printFigure(n):
    if n == 0:
        return
    # pre action
    print("*"*n)
    printFigure(n-1)
    print("#"*n)

printFigure(5)

'''
*****
****
***
**
*
#
##
###
####
#####
'''