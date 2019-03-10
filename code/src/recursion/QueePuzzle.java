package recursion;



public class QueePuzzle {

    static final int Size = 8;
    //Define a Data Structure to Hold the Chessboard
    static boolean[][] chessboard = new boolean[Size][Size];

    //Define a Data Structure to Hold the Attacked Positions
    static boolean[] attackedColumns = new boolean[8];
    static boolean[] attackedLeftDiagonals = new boolean[15];
    static boolean[] attackedRightDiagonals = new boolean[15];

    static int solutionFound = 0;
    //Write the Backtracking Algorithm
    static void PutQueens(int row){
        if(row == Size)
            printSolution();
        for(int col=0;col<Size;col++){
            if(CanplaceQueen(row,col)){
                MarkAllAttackedPosition(row,col);
                PutQueens(row+1);
                UnmarkAllAttackedPosition(row,col);
            }
        }
    }

    private static void UnmarkAllAttackedPosition(int row,int col) {
        MarkAllAttackedPosition(row,col);
    }

    private static void MarkAllAttackedPosition(int row, int col) {
        attackedColumns[col] = !attackedColumns[col];
        attackedLeftDiagonals[col-row+Size-1] = !attackedLeftDiagonals[col-row+Size-1];
        attackedRightDiagonals[col+row] = !attackedRightDiagonals[col+row];
        chessboard[row][col] = !chessboard[row][col];
    }

    //Check if a Position is Free
    private static boolean CanplaceQueen(int row, int col) {
        boolean result = attackedColumns[col]
                || attackedLeftDiagonals[col-row+Size-1]
                || attackedRightDiagonals[col+row];
        return !result;
    }

    static void printSolution(){
        for(int row=0;row<Size;row++){
            for(int col=0;col<Size;col++){
                System.out.print(chessboard[row][col]?"*":"-");
            }
            System.out.println();
        }
        solutionFound++;
        System.out.println("Found " + solutionFound);
    }

    public static void main(String[] args) {
        PutQueens(0);
    }
}

/**

 *-------
 ----*---
 -------*
 -----*--
 --*-----
 ------*-
 -*------
 ---*----
 Found 1



 -------*
 ---*----
 *-------
 --*-----
 -----*--
 -*------
 ------*-
 ----*---
 Found 92

 */