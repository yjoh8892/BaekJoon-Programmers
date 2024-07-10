import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
		String S = sc.next();
		int count = 0;
		
		for (int i = 0; i < N; i++) {
			if ((char)S.charAt(i) == 'a' || (char)S.charAt(i) == 'e' || (char)S.charAt(i) == 'i' || (char)S.charAt(i) == 'o' || (char)S.charAt(i) == 'u') {
				count++;
			}
		}
        
		System.out.println(count);
    }
}