using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        
        Array.Sort(d);
        
        for (int i = 0; i < d.Length; i++)
        {
            if (budget >= d[i])
            {
                budget -= d[i];
                answer++;
            }
        }
        // 오름차순 정렬 후 하나씩 추가해보면 알 수 있음
        return answer;
    }
}
