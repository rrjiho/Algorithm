using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int n = 2;
        int[] answer = new int[n];
        
        int x_max = (board[0] / 2);
        int y_max = (board[1] / 2);
        
        foreach(string str in keyinput)
        {
            if(str == "left" && answer[0] > -x_max)
                answer[0]--;
            else if(str == "right" && answer[0] < x_max)
                answer[0]++;
            else if(str == "down" && answer[1] > -y_max)
                answer[1]--;
            else if(str == "up" && answer[1] < y_max)
                answer[1]++;               
        }
        
        return answer;
    }
}
