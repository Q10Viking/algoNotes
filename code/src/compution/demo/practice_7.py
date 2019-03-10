def PermuteRep(arr,start,end):
    print(arr)
    for left in range(end-1,start-1,-1):
        # 让右边所有的元素都出于这个left位置，然后在恢复，向前处理一个元素
        for right in range(left+1,end+1,1):
            if arr[left] != arr[right]:
                swap(arr,left,right)
                PermuteRep(arr,left+1,end)
        # 恢复，准备下一次新元素的处理
        firstElement = arr[left]
        for i in range(left,end):
            arr[i] = arr[i+1]
        arr[end] = firstElement

def swap(arr,j,i):
    arr[i],arr[j] = arr[j],arr[i]

if __name__ == '__main__':
    # arr=["A","O","B","A"]
    arr = ["O","A","O","O"]
    #arr.sort()
    PermuteRep(arr,0,len(arr)-1)