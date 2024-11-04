using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        string str = "";
        
        foreach (char c in myString)
        {
            if (c == 'A')
            {
                str += 'B';
            }
            else if (c == 'B')
            {
                str += 'A';
            }
        }
        
        answer = str.Contains(pat) ? 1 : 0;
        
        return answer;
    }
}
