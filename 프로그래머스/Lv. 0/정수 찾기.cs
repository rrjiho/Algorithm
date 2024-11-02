using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        int answer = 0;
        
        foreach (int i in num_list)
        {
            if (i == n)
                answer = 1;
        }
        // answer = num_list.Contains(n) ? 1 : 0;
        return answer;
    }
}
