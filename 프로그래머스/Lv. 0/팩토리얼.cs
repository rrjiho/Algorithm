using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;    
        
        int cnt = 1;
        int a = 1;
        while(cnt <= n)
        {
            cnt *= a;
            a++;
            answer++;
        }
        
        answer--;
        return answer;
    }
}
