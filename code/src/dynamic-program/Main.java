public class Main{
    public static void main(String[] args){
        int[][] cells =
        {
            {2, 6, 1, 8, 9, 4, 2},
            {1, 8, 0, 3, 5, 6, 7},
            {3, 4, 8, 7, 2, 1, 8},
            {0, 9, 2, 8, 1, 7, 9},
            {2, 7, 1, 9, 7, 8, 2},
            {4, 5, 6, 1, 2, 5, 6},
            {9, 3, 5, 2, 8, 1, 9},
            {2, 3, 4, 1, 7, 2, 8}
        };

        int rows = cells.length;
        int cols = cells[0].length;

        //bottom-to-up准备数据
        int[][] sum_matrix = new int[rows][cols];
        for(int row=0;row<rows;row++){
            for(int col=0;col<cols;col++){
                int maxPrev = Integer.MIN_VALUE;
                // find max sum_value on left
                if(col > 0 && sum_matrix[row][col-1]>maxPrev){
                    maxPrev = sum_matrix[row][col-1];
                }
                //find max sum_value on up
                if(row > 0 && sum_matrix[row-1][col] > maxPrev){
                    maxPrev = sum_matrix[row-1][col];
                }
                
                sum_matrix[row][col] = cells[row][col];
                if(maxPrev != Integer.MIN_VALUE){
                    sum_matrix[row][col] += maxPrev;
                }
            }
        }

        //find the path
        boolean[][] path = new boolean[rows][cols]; //default value is false
        int cur_row = rows-1;
        int cur_col = cols-1;

        while(cur_row>=0 && cur_col>=0 ){
            path[cur_row][cur_col] = true;
            int a = sum_matrix[cur_row][cur_col]-cells[cur_row][cur_col];
            if(cur_row>0 && sum_matrix[cur_row-1][cur_col] == a){
                cur_row -= 1;
            }else{
                cur_col -= 1;
            }
        }


        //print the path
        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                if(path[i][j]){
                    //green
                    System.out.print("\033[31m"+cells[i][j]);
                }else{
                    System.out.print("\033[0m"+cells[i][j]);
                }
            }
            System.out.println();
        }
    }

}