import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int N = sc.nextInt();
        
        Set<String> set = new HashSet<>();
        set.add("ChongChong");
        
        for (int i = 0; i < N; i++) {
            String person1 = sc.next();
            String person2 = sc.next();
            
            if (set.contains(person1) || set.contains(person2)) {
                set.add(person1);
                set.add(person2);
            }
        }
        System.out.println(set.size());
    }
}