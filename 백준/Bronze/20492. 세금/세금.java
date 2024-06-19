import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        double N = sc.nextInt();
        double No1 = N * 0.78;
        double No2 = N * 0.8 + N * 0.2 * 0.78;
        
        System.out.println((int)No1 + " " + (int)No2);
    }
}