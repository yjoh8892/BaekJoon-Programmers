import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int X = sc.nextInt();
        int i = 0;
		int val = 0;
		
        while(val < X) {
			i++;
			val += i;
		}
		
		if(i % 2 == 0) {
			System.out.println((i - (val - X)) + "/" + (i + (((val - i) - X) + 1)));
		} else {
			System.out.println((i + (((val - i) - X) + 1)) + "/" + (i - (val - X)));
		}
    }
}