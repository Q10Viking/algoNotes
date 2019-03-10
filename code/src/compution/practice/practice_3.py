k,n = 3,4
arr = [None]*k
free = [1,2,3,4]
not_used = [True]*n
def generateVariationsNoRepetitions(index):
    if index >= k:
        print(arr)
    else:
        for i in range(0,n):
            if not_used[i]:
                not_used[i] = False
                arr[index] = free[i]
                generateVariationsNoRepetitions(index+1)
                not_used[i] = True
      

generateVariationsNoRepetitions(0)