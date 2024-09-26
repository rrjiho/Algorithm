using System;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int cnt = 0;
        foreach (char c in s)
        {
            if (c == '(')
                cnt++;
            else if (c == ')')
                cnt--;
            
            if (cnt < 0)
            {
                answer = false;
                break;
            }
        }
        
        if (cnt == 0)
            answer = true;
        else
            answer = false;
        
        return answer;
    }
}
