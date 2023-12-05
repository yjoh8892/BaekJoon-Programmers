import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int[][] arr2D = new int[9][9];
        int Max = 0;
        int row = 0;
        int col = 0;
        
        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++) {
                arr2D[i][j] = sc.nextInt();
                
                if(Max < arr2D[i][j]) {
                    Max = arr2D[i][j];
                    row = i;
                    col = j;
                }
            }
        }
        System.out.println(Max);
        System.out.println((row + 1) + " " + (col + 1));
    }
}