n,k = 2,4

arr = [0]*k

while True:
    # print 
    print(*arr,sep="")
    index = k-1
    # find the index that will be dealed
    while index>=0 and arr[index] == n-1:
        index -= 1
    # find all result
    if index < 0:
        break;
    arr[index] += 1

    # 处理进制
    for i in range(index+1,len(arr)):
        arr[i] = 0

'''
0000
0001
0010
0011
0100
0101
0110
0111
1000
1001
1010
1011
1100
1101
1110
1111
'''

