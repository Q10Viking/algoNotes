KEY_NOT_FOUND = -1
def interpolation_search(sortedarr,key):
    low = 0
    high = len(sortedarr)-1
    while not high < low:
        mid = low+(key - sortedarr[low])*(high-low)//(sortedarr[high]-sortedarr[low])
        if sortedarr[mid]<key:
            low = mid + 1
        elif sortedarr[mid]>key:
            high = mid - 1
        else:
            return mid
    return KEY_NOT_FOUND

if __name__ == '__main__':
    arr = [0, 2, 3, 5, 12, 23, 43, 45, 100, 342]
    key = int(input("please input your number: "))
    result = interpolation_search(arr,key)
    if result != -1:
        print("the key: %d is in the arr[%d] = %d" % (key,result,arr[result]))
    else:
        print("not found")
'''
please input your number: 5
the key: 5 is in the arr[3] = 5
'''