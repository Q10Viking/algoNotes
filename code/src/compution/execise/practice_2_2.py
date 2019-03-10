
def generate_variations(arr,free,index,start):
    # The bottom of the recursion is reached when we've filled K
    # K elements that's the current index is outside the valid range
    if index >= len(arr):
        print(arr)
    else:
        # 从大集合中取元素
        for i in range(start,len(free)):
            arr[index] = free[i]
            swap(free,index,i)
            #TODO: continue generating varations  starting with index+1
            generate_variations(arr,free,index+1,index+1)
            swap(free,index,i)

def swap(arr,i,j):
    arr[i],arr[j] = arr[j],arr[i]


if __name__ == '__main__':
    # such as input 3 2
    n,k = map(int,input().split(' '))
    # result will be filled
    arr = [None]*k
    free = [_ for _ in range(1,n+1)]
    generate_variations(arr,free,0,0)

'''
3 2
[1, 2]
[1, 3]
[2, 1]
[2, 3]
[3, 2]
[3, 1]
'''