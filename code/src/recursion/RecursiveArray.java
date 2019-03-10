package recursion;

public class RecursiveArray {
    public static void main(String[] args) {
        int[] arr = new int[]{1,2,3,4,5,6};
        int result = FindSum(arr,arr.length-1);
        System.out.println(result);
    }

    public static int FindSum(int arr[],int index){
        //// TODO: 2/28/19 set bottomm of recursion
        if(index == 0)
            return arr[index];
        return arr[index]+FindSum(arr,index-1);
    }
}
