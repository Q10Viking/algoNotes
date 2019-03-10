def Gen01(arr,n):
    if n == len(arr):
        print(*arr,sep="")
        return

    for i in range(2):
        arr[n] = i
        Gen01(arr,n+1)
    

arr = [None]*3
Gen01(arr,0)

'''
000
001
010
011
100
101
110
111
'''