import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        String S = sc.next();
        
        if (S.equals("M")) {
            System.out.println("MatKor");
        } else if (S.equals("W")) {
            System.out.println("WiCys");
        } else if (S.equals("C")) {
            System.out.println("CyKor");
        } else if (S.equals("A")) {
            System.out.println("AlKor");
        } else if (S.equals("$")) {
            System.out.println("$clear");
        }
    }
}