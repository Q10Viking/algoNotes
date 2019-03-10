import random
def merge_sort(arr):
    if len(arr) == 1:
        return arr  # list aready sorted
    middle = len(arr)//2
    left_arr = arr[:middle]
    right_arr = arr[middle:]
    left_arr = merge_sort(left_arr)
    right_arr = merge_sort(right_arr)
    return merge(left_arr,right_arr)

def merge(leftList,rightList):
    # 新建一个新的list用于存储合并的结果
    mergeList = [None]*(len(leftList)+len(rightList))
    leftIndex,rightIndex,mergedIndex = 0,0,0
    # 比较两个列表添加
    while leftIndex<len(leftList) and rightIndex<len(rightList):
        if leftList[leftIndex] < rightList[rightIndex]:
            mergeList[mergedIndex] = leftList[leftIndex]
            leftIndex += 1
        else:
            mergeList[mergedIndex] = rightList[rightIndex]
            rightIndex += 1
        mergedIndex += 1
    # 处理还有剩余项的列表
    while leftIndex < len(leftList):
        mergeList[mergedIndex]= leftList[leftIndex]
        leftIndex += 1
        mergedIndex += 1
    while rightIndex < len(rightList):
        mergeList[mergedIndex]=rightList[rightIndex]
        rightIndex += 1
        mergedIndex += 1
    return mergeList


if __name__ == '__main__':
    #arr = [_ for _ in range(10)]
    arr = [3,5,23,12,0,2,45,100,342,43,2]
    random.shuffle(arr)
    print("Before: ",arr)
    arr = merge_sort(arr)
    print("After: ",arr)

'''
Before:  [4, 1, 5, 8, 0, 2, 6, 3, 7, 9]
After:  [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
'''