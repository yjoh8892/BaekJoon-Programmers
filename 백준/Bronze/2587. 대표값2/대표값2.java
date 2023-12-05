import java.util.Scanner;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int[] array = new int[5];
        int sum = 0;
        
        for(int i = 0; i < 5; i++) {
            array[i] = sc.nextInt();
        }
        
        Arrays.sort(array);
        
        for(int i = 0; i < 5; i++) {
            sum += array[i];
        }
        
        System.out.println(sum / 5);
        System.out.println(array[2]);
    }
}