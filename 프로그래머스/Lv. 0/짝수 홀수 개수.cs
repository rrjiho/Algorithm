using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int n = 2;
        int[] answer = new int[n];
        
        foreach(int num in num_list)
        {
            if(num % 2 == 0)
                answer[0]++;
            else
                answer[1]++;
        }
        
        return answer;
    }
}
