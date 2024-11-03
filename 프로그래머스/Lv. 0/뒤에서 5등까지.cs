using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int len = 5;
        int[] answer = new int[len];
        
        Array.Sort(num_list);
        
        for (int i = 0; i < len; i++)
        {
            answer[i] = num_list[i];
        }
        
        return answer;
    }
}
