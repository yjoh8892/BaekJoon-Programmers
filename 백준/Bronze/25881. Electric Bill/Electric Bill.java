import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int first = sc.nextInt();
        int additional = sc.nextInt();
        int n = sc.nextInt();
        
        for (int i = 0; i < n; i++) {
            int energy = sc.nextInt();
            int money = 0;
            
            if (energy <= 1000) {
                money = first * energy;
            } else {
                money = first * 1000 + additional * (energy - 1000);
            }
            System.out.println(energy + " " + money);
        }
    }
}