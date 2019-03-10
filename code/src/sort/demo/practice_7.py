KEY_NOT_FOUND = -1
# find the index of key in the arr list
def BinarySearch(arr,key,start,end):
    while not end<start:
        mid = (start+end+1)//2
        if arr[mid]>key:
            end = mid-1
        elif arr[mid]<key:
            start = mid+1
        else:
            return mid
    return KEY_NOT_FOUND

if __name__ == '__main__':
    arr = [0, 2, 3, 5, 12, 23, 43, 45, 100, 342]
    key = int(input("please input your number: "))
    result = BinarySearch(arr,key,0,len(arr)-1)
    if result != -1:
        print("the key: %d is in the arr[%d] = %d" % (key,result,arr[result]))
    else:
        print("not found")
