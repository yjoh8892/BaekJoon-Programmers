import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int B = sc.nextInt();
        
        char[] arr = new char[36];
		
		for (int i = 0; i < 10; i++) {
			arr[i] = (char) (i + '0');
		}
        
		for (int i = 10; i < 36; i++) {
			arr[i] = (char) (i + 'A' - 10);
		}
        
		long result = 0;
		String re = "";
        
		while (N > 0) {
			result = N % B;
			N = N / B;
			re = arr[(int) result] + re;
		}
		System.out.print(re);
    }
}