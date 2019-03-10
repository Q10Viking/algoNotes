def PermuteRep(arr,start,end):
    print(arr)
    for left in range(end-1,start-1,-1):
        for right in range(left+1,end+1,1):
            if arr[left] != arr[right]:
                swap(arr,left,right)
                PermuteRep(arr,left+1,end)
        firstElement = arr[left]
        for i in range(left,end):
            arr[i] = arr[i+1]
        arr[end] = firstElement

def swap(arr,j,i):
    arr[i],arr[j] = arr[j],arr[i]

if __name__ == '__main__':
    # arr=["A","O","B","A"]
    # arr = ["O","A","O","O","A"]
    arr = ['O','A','O','O']
    arr.sort()
    PermuteRep(arr,0,len(arr)-1)
'''
['A', 'A', 'A', 'O']
['A', 'A', 'O', 'A']
['A', 'O', 'A', 'A']
['O', 'A', 'A', 'A']
'''