def generate_variations(arr,size_of_set,index,start):
    # The bottom of the recursion is reached when we've filled K
    # K elements that's the current index is outside the valid range
    if index >= len(arr):
        print(arr)
    else:
        # 从大集合中取元素,考虑到该组合要求顺序没有影响(1,2)与（2,1）是相同的，所以for循环以start参数开始
        # 该start，是arr前一个元素的后一个元素，即递归时传递的i
        for i in range(start,size_of_set+1):
            arr[index] = i
            #TODO: continue generating varations  starting with index+1
            generate_variations(arr,size_of_set,index+1,i+1)


if __name__ == '__main__':
    # such as input 3 2
    n,k = map(int,input().split(' '))
    # result will be filled
    arr = [None]*k
    generate_variations(arr,n,0,1)

'''
5 3
[1, 2, 3]
[1, 2, 4]
[1, 2, 5]
[1, 3, 4]
[1, 3, 5]
[1, 4, 5]
[2, 3, 4]
[2, 3, 5]
[2, 4, 5]
[3, 4, 5]
'''