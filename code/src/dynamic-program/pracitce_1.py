
def FindLongestIncreasingSubsequence(sequence):
    maxlen = 0
    # the index of last element in the longest sequence
    lastIndex = 0
    len_seq = [None]*len(sequence)
    prev = [None]*len(sequence)
    for i in range(len(sequence)):
        len_seq[i] = 1
        prev[i] = -1
        for j in range(i):
            #TODO: check if element is smaller than current and its LIS is the same length
            #or larger
            if sequence[j]<sequence[i] and len_seq[j]+1>len_seq[i]:
                # increase current length
                len_seq[i] += 1
                # mark the index of the previous element in the new LIS
                prev[i] = j
        if len_seq[i]>maxlen:
            maxlen = len_seq[i]
            lastIndex = i

    #TODO recover the LIS by walking through the prev[]
    LIS = []
    current_index = lastIndex
    while current_index != -1:
        LIS.insert(0,sequence[current_index])
        current_index = prev[current_index]
        
    return LIS

if __name__ == '__main__':

    sequence = [3,14,5,12,15,7,8,9,11,10,1]
    longestSeq = FindLongestIncreasingSubsequence(sequence)
    print("max length is: ",len(longestSeq))
    print(longestSeq)

'''
max length is:  6
[3, 5, 7, 8, 9, 11]
'''
    