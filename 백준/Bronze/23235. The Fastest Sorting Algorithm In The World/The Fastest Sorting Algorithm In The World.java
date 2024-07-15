import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int count = 1;
        
		while (N != 0) {
			for (int i = 0; i < N; i++) {
				int X = sc.nextInt();
			}
            
			System.out.println("Case " + count + ": Sorting... done!");
            
			count++;
			N = sc.nextInt();
		}
    }
}