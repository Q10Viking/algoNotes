import random
def bubble_sort(arr):
    sorted = False
    unsorted_length = len(arr)
    while not sorted:
        sorted = True
        for i in range(unsorted_length-1):
            # change element
            if arr[i]>arr[i+1]:
                arr[i],arr[i+1] = arr[i+1],arr[i]
                sorted = False
        # update unsorted elements
        unsorted_length -= 1

if __name__ == "__main__":
    arr = [i for i in range(10)]
    random.shuffle(arr)
    print("before: ",arr)
    bubble_sort(arr)
    print("finished: ",arr)