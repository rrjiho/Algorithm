using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int zeroCnt = 0;
        int cnt = 0;
        
        int rank = 7;
        
        foreach(int s in lottos)
        {
            if(s == 0)
                zeroCnt++;
            
            if(win_nums.Contains(s))
                cnt++;    
        }
        
        answer[0] = Math.Min(rank - (cnt + zeroCnt), 6);
        answer[1] = Math.Min(rank - cnt, 6);
        
        return answer;
    }
}
