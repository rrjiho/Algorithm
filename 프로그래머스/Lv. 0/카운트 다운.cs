using System;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        int len = start_num - end_num;
        
        int[] answer = new int[len + 1];
        
        
        for (int i = 0; i <= len; i++)
        {
            answer[i] = start_num--;
        }
        
        return answer;
    }
}
