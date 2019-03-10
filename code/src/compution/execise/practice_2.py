def generate_variations(arr,used,size_of_set,index):
    # The bottom of the recursion is reached when we've filled K
    # K elements that's the current index is outside the valid range
    if index >= len(arr):
        print(arr)
    else:
        # 从大集合中取元素
        for i in range(1,size_of_set+1):
            if not used[i]:
                # TODO Mark i as used
                used[i] = True
                arr[index] = i
                #TODO: continue generating varations  starting with index+1
                generate_variations(arr,used,size_of_set,index+1)
                # TODO unmark i as used
                used[i] = False

if __name__ == '__main__':
    # such as input 3 2
    n,k = map(int,input().split(' '))
    # result will be filled
    arr = [None]*k
    # keep tack of used numbers
    used = [False]*(n+1)
    generate_variations(arr,used,n,0)

'''
[1, 2]
[1, 3]
[2, 1]
[2, 3]
[3, 1]
[3, 2]
'''