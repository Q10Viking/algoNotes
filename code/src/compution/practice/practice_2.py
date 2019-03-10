k,n=3,4
arr = [0]*k
def VariationsNoRep(index):
    if index >= k:
        print(arr)
    else:
        for i in range(index,n):
            arr[index] = i
            #注意传递的是index而不是i,传i会形成无限递归
            VariationsNoRep(index+1)

if __name__ == "__main__":
    VariationsNoRep(0)