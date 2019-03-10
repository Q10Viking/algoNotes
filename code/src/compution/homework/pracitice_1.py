
def perm(arr,index,start):
    print(arr)
    for left in range(len(arr)-1,start-1,-1):
        for right in range(left+1,len(arr)):
            swap(arr,left,right)
            perm(arr,left+1,left+1)
            swap(arr,left,right)

def swap(arr,left,right):
    arr[left],arr[right] = arr[right],arr[left]

if __name__ == "__main__":
    n = int(input())
    arr = [i for i in range(1,n+1)]
    perm(arr,0,0)

'''
3
[1, 2, 3]
[1, 3, 2]
[2, 1, 3]
[2, 3, 1]
[3, 2, 1]
[3, 1, 2]
'''