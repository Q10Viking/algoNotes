# 这才理想的答案,从空间和时间上都是节省的，并且注意函数swap的写法
k,n = 4,4
arr = [None]*k
count = 0
free = [1,2,3,4]
#free = ["Python","Java","C","JavaScript"]
def generateVariationsNoRepetitions(index):
    global count
    if index >= k:
        count += 1
        print(count)
        print(arr)
    else:
        for i in range(index,n):
            arr[index] = free[i]
            Swap(free,i,index)
            #print(free)
            generateVariationsNoRepetitions(index+1)
            Swap(free,i,index)
            
      
def Swap(f,a,b):
    f[a],f[b] = f[b],f[a]

'''
def Swap(
    a,b):
    a,b = b,a
'''

generateVariationsNoRepetitions(0)