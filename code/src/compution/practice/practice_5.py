fruits = ["Apple","Bananas","Orange"]

def Perm(arr,index):
    if index >= len(arr):
        print("( ",*arr," )")
    else:
        Perm(arr,index+1)
        for i in range(index+1,len(arr)):
            swap(arr,index,i)
            Perm(arr,index+1)
            swap(arr,index,i)

def swap(arr,i,j):
    arr[i],arr[j] = arr[j],arr[i]

if __name__ == '__main__':
    Perm(fruits,0)