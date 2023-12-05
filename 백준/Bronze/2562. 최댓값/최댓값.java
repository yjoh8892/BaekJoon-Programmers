import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = 9;
        int[] arr = new int[N];
        int max = 0;
        int count = 0;
        int index = 0;
        
        for(int i = 0; i < N; i++) {
            arr[i] = sc.nextInt();
        }
        
        for(int i = 0; i < arr.length; i++) {
            count++;
            
            if(max < arr[i]) {
                max = arr[i];
                index = count;
            }
        }
        System.out.println(max);
        System.out.println(index);
    }
}