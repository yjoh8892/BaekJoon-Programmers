import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int[] N = new int[8];
        int count = 0;
        
		for (int i = 0; i < 8; i++) {
			N[i] = sc.nextInt();
		}
		
		for (int i = 0; i < 8; i++) {
			if (N[i] == 0 || N[i] == 1) {
                count++;
			} else {
				break;
			}
		}
		
		if (count == 8) {
			System.out.println("S");
		} else {
			System.out.println("F");
		}
    }
}