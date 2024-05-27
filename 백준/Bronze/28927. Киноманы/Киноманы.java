import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int t1 = sc.nextInt();
        int e1 = sc.nextInt();
        int f1 = sc.nextInt();
        int t2 = sc.nextInt();
        int e2 = sc.nextInt();
        int f2 = sc.nextInt();
        
        int Max = 3 * t1 + 20 * e1 + 120 * f1;
        int Mel = 3 * t2 + 20 * e2 + 120 * f2;
        
        if (Max > Mel) {
            System.out.println("Max");
        } else if (Mel > Max) {
            System.out.println("Mel");
        } else {
            System.out.println("Draw");
        }
    }
}