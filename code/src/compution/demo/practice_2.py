def perm(free,index):
    if index >= len(free):
        print(free)
    else:
        perm(free,index+1)
        # 需要回溯回来
        for i in range(index+1,len(free)):
            swap(free,index,i)
            perm(free,index+1)
            swap(free,index,i)



def swap(arr,i,j):
    arr[i],arr[j] = arr[j],arr[i]


if __name__ == '__main__':
    # such as input 2
    n = int(input())
    free = [_ for _ in range(1,n+1)]
    perm(free,0)
    
'''
3
[1, 2, 3]
[1, 3, 2]
[2, 1, 3]
[2, 3, 1]
[3, 2, 1]
[3, 1, 2]
'''