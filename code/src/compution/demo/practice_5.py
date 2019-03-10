def perm(free,index):
    if index >= len(free):
        print(free)
    else:
        perm(free,index+1)
        # 需要回溯回来
        for i in range(index+1,len(free)):
            swap(free,index,i)
            perm(free,index+1)
            swap(free,index,i)

def swap(arr,i,j):
    arr[i],arr[j] = arr[j],arr[i]


if __name__ == "__main__":
    #fruits = ["A","O","B","A"]
    fruits = ["A","O","B","C"]
    perm(fruits,0)

'''
['A', 'O', 'B', 'C']
['A', 'O', 'C', 'B']
['A', 'B', 'O', 'C']
['A', 'B', 'C', 'O']
['A', 'C', 'B', 'O']
['A', 'C', 'O', 'B']
['O', 'A', 'B', 'C']
['O', 'A', 'C', 'B']
['O', 'B', 'A', 'C']
['O', 'B', 'C', 'A']
['O', 'C', 'B', 'A']
['O', 'C', 'A', 'B']
['B', 'O', 'A', 'C']
['B', 'O', 'C', 'A']
['B', 'A', 'O', 'C']
['B', 'A', 'C', 'O']
['B', 'C', 'A', 'O']
['B', 'C', 'O', 'A']
['C', 'O', 'B', 'A']
['C', 'O', 'A', 'B']
['C', 'B', 'O', 'A']
['C', 'B', 'A', 'O']
['C', 'A', 'B', 'O']
['C', 'A', 'O', 'B']
'''