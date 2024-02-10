import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        int M = sc.nextInt();
        int count = 0;
        
        Map<String, Integer> map = new HashMap<>();
        
        for (int i = 0; i < N; i++) {
            map.put(sc.next(), 0);
        }
        
        for (int i = 0; i < M; i++) {
            if (map.containsKey(sc.next())) {
                count++;
            }
        }
        System.out.print(count);
    }
}