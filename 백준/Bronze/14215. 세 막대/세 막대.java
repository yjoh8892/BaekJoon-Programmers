import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        int Max = 0;
        
        if (a > b) {
            if (b > c) {
                Max = a;
            } else {
                Max = (a > c) ? a : c;
            }
        } else {
            Max = (b > c) ? b : c;
        }
        
        if (a + b + c - Max > Max) {
            System.out.println(a + b + c);
        } else {
            System.out.println((a + b + c - Max) * 2 - 1) ;
        }
    }
}