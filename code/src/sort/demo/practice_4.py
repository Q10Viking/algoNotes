import random
def quick_sort(arr,lo,hi):
    if lo < hi:
       # p = Lomuto_Partion(arr,lo,hi)
        p = Hoare_Partion(arr,lo,hi)
        quick_sort(arr,lo,p)
        quick_sort(arr,p+1,hi)
    
# Lomuto partioning
def Lomuto_Partion(arr,lo,hi):
    # 枢纽点
    pivot = arr[lo]
    store = lo+1
    for i in range(store,hi+1):
        if arr[i] <= pivot:
            swap(arr,i,store)
            store += 1
    store -= 1
    swap(arr,lo,store)
    return store


# Hoare Partitioning
def Hoare_Partion(arr,lo,hi):
    pivot = arr[lo]
    left = lo+1
    right = hi
    while True:
        while left<=hi and arr[left] <= pivot:
            left += 1
        while arr[right] > pivot:
            right -= 1
        if right<left:
            break
        else:
            swap(arr,left,right)
    swap(arr,lo,right)
    return right

def swap(arr,i,j):
    arr[i],arr[j] = arr[j],arr[i]

if __name__ == '__main__':
    arr = [_ for _ in range(10)]
    random.shuffle(arr)
    print("Before: ",arr)
    quick_sort(arr,0,len(arr)-1)
    print("After: ",arr)
