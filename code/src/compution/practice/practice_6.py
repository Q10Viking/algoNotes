def PermuteRep(arr,start,end):
    print(arr)
    for left in range(end-1,start-1,-1):
        for right in range(left+1,end+1,1):
            if arr[left] != arr[right]:
                arr[left],arr[right] = arr[right],arr[left]
                PermuteRep(arr,left+1,end)

        firstElement = arr[left]
        for i in range(left,end):
            arr[i] = arr[i+1]
        arr[end] = firstElement

arr = [2,3,5,4]
arr.sort()
PermuteRep(arr,0,len(arr)-1)
