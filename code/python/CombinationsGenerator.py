

def GenCombs(arr,index,startnum,endnum):
    if index >= len(arr):
        print("(",*arr,")")
        return
    for i in range(startnum,endnum+1):
        arr[index] = i;
        GenCombs(arr,index+1,i+1,endnum)

arr = [None]*3
GenCombs(arr,0,4,8)

'''
( 4 5 6 )
( 4 5 7 )
( 4 5 8 )
( 4 6 7 )
( 4 6 8 )
( 4 7 8 )
( 5 6 7 )
( 5 6 8 )
( 5 7 8 )
( 6 7 8 )
'''