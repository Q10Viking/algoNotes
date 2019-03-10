def generate_variations(arr,index):
    # The bottom of the recursion is reached when we've filled K
    # K elements that's the current index is outside the valid range
    if index >= len(arr):
        print(arr)
    else:
        # 从大集合中取元素
        for i in range(1,n+1):
            arr[index] = i
            #TODO: continue generating varations  starting with index+1
            generate_variations(arr,index+1)

if __name__ == '__main__':
    # such as input 3 2
    n,k = map(int,input().split(' '))
    # result will be filled
    arr = [None]*k

    generate_variations(arr,0)

'''
3 2
[1, 1]
[1, 2]
[1, 3]
[2, 1]
[2, 2]
[2, 3]
[3, 1]
[3, 2]
[3, 3]
'''