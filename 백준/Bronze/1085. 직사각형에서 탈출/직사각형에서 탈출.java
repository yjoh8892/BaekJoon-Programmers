import java.util.Scanner;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int[] arr = new int[4];
        int x = sc.nextInt();
        int y = sc.nextInt();
        int w = sc.nextInt();
        int h = sc.nextInt();
        
        w = w - x;
        h = h - y;
        
        arr[0] = x;
        arr[1] = y;
        arr[2] = w;
        arr[3] = h;
        
        Arrays.sort(arr);
        
        System.out.println(arr[0]);
    }
}