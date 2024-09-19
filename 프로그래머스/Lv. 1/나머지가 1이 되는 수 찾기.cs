using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for (int i = 1; i < n; i++)
        {
            if (n % i == 1)
            {
                answer = i;
                break;
            }
        }

      /*while (n % answer != 1)
      {
          answer++;
      }*/ 같은 로직 짧은 코드
        
        return answer;
    }
}
