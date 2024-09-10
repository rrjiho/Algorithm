using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for (int i = 1; i <= n; i++)
        {
            if(n % i == 0)
                answer++;
        }

        // int answer = Enumeralbe.Range(1, n).Count(x => n % x == 0);
      
        return answer;
    }
}
