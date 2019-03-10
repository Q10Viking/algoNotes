
n = 3
k = 2
arr = [0]*k

while True:
    print(arr)
    index = k -1
    while index >=0 and arr[index] == n-1:
        index -= 1
    if index < 0:
        break
    arr[index] += 1
    for i in range(index+1,k):
        arr[i] = 0

# 找到要加1的地方，
# 然后需要处理进制的地方变成0