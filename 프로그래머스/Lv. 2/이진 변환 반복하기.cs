using System;

public class Solution {
    public int[] solution(string s) {
        int len = 2;
        int[] answer = new int[len];
        
        int totalCount = 0;
        int zeroCount = 0;
        
        while (s != "1")
        {
            int cnt = 0;
            foreach (char c in s)
            { 
                if (c == '0')
                    cnt++;
            }
            s = Convert.ToString(s.Length - cnt, 2);
            zeroCount += cnt;
            totalCount++;
        }
        
        answer[0] = totalCount;
        answer[1] = zeroCount;
        
        return answer;
    }
}
