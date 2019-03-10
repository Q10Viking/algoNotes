import random

def my_shuffle(arr):
    for i in range(0,len(arr)):
        # Exchange array[i] with random element in array[i … n-1]
        random_index = random.randint(0,len(arr)-1)
        arr[i],arr[random_index] = arr[random_index],arr[i]
    return arr

if __name__ == '__main__':
    arr = [_  for _ in range(10)]
    print("before: ",arr)
    arr = my_shuffle(arr)
    print("after ",arr)
'''
before:  [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
after  [2, 6, 7, 0, 4, 1, 8, 5, 3, 9]
'''