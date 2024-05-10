import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int X = sc.nextInt();
        
        if (X == 0 || X == 1) {
            System.out.println(0);
        } else if ((X - 2) % 7 == 0) {
            System.out.println(1);
        } else {
            System.out.println(0);
        }
    }
}