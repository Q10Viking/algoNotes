import random
def insertion_sort(arr):
    for i in range(len(arr)):
        first_unsorted_index = i
        # note that the first_ubsorted is > 0 not >=0
        while first_unsorted_index>0 and arr[first_unsorted_index] < arr[first_unsorted_index-1]:
            swap(arr,first_unsorted_index,first_unsorted_index-1)
            first_unsorted_index -= 1

def swap(arr,i,j):
    arr[i],arr[j] = arr[j],arr[i]

if __name__ == '__main__':
    arr = [_ for _ in range(20)]
    random.shuffle(arr)
    print("Before: ",arr)
    insertion_sort(arr)
    print("After: ",arr)
'''
Before:  [9, 15, 2, 16, 17, 3, 7, 1, 14, 6, 13, 19, 8, 5, 10, 12, 11, 18, 4, 0]
After:  [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19]
'''