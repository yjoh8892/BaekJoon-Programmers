import java.util.Scanner;

public class Main {
    static int[][] arr = new int[30][30];
    
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int T = sc.nextInt();
        
        for(int i = 0; i < T; i++) {
			int N = sc.nextInt();
			int M = sc.nextInt();
						
			System.out.println(combi(M, N));
		}
    }
    
    static int combi(int n, int r) {
        if(arr[n][r] > 0) {
			return arr[n][r]; 
		}
        
		if(n == r || r == 0) {
			return arr[n][r] = 1;
		}
        
		return arr[n][r] = combi(n - 1, r - 1) + combi(n - 1, r);
    }
}