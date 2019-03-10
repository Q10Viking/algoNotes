import random
def select_sort(arr):
    for i in range(len(arr)-1):
        # Find the min element in the unsorted range arr[left,n-1]
        minIndex = i
        for j in range(i+1,len(arr)):
            if arr[minIndex] > arr[j]:
                minIndex = j
        arr[i],arr[minIndex] = arr[minIndex],arr[i]
    

if __name__ == "__main__":
    arr = [i for i in range(10)]
    random.shuffle(arr)
    print("before: ",arr)
    select_sort(arr)
    print("finished: ",arr)

'''
before:  [0, 5, 2, 9, 7, 8, 4, 3, 6, 1]
finished:  [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
'''